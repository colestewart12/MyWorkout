<template>
  <Dialog v-model="modelValue" @update:modelValue="cancel" :title="titleText">
    <template v-slot:menuItems v-if="!isNew">
      <v-list-item @click="dialogOpen = true">
        <template v-slot:prepend>
          <v-icon size="small" color="error" class="mr-4" icon="fas fa-trash" />
        </template>
        Delete
      </v-list-item>
    </template>
    <v-form
      ref="bracketExerciseForm"
      v-model="isBracketExerciseValid"
      class="mb-3"
    >
      <c-loader-status
        :loaders="{
          '': [
            bracketExercise.$save,
            bracketExercise.$delete,
            bracketExercise.$load,
          ],
        }"
      />
      <v-row>
        <v-col cols="12" md="6">
          <v-combobox
            v-model="selectedExercise"
            :items="exercises.$items"
            item-title="name"
            label="Exercise"
            clearable
            hide-details
          />
        </v-col>
      </v-row>
    </v-form>
    <template v-slot:actions>
      <v-btn @click="cancel" color="primary" variant="tonal"> Cancel </v-btn>
      <v-btn
        @click="save"
        :disabled="!isBracketExerciseValid || isSaving"
        :loading="isSaving"
        color="primary"
        variant="flat"
        type="submit"
      >
        Save
      </v-btn>
    </template>
  </Dialog>
  <DialogConfirmation
    v-model="dialogOpen"
    title="Delete BracketExercise"
    buttonText="Delete"
    buttonColor="error"
    @confirm="deleteBracketExercise"
  >
  </DialogConfirmation>
</template>

<script setup lang="ts">
import router from "@/router";
import {
  BracketExerciseViewModel,
  ExerciseListViewModel,
} from "@/viewmodels.g";
import { VForm } from "vuetify/components";
import { useFormValidation } from "@/composables/useFormValidation";

const modelValue = defineModel<boolean>({ default: false });
const dialogOpen = ref(false);

const props = defineProps<{
  bracketExercise: BracketExerciseViewModel;
  bracketId: number;
  workoutId: number;
}>();

const isNew = computed(() => !props.bracketExercise?.bracketExerciseId);

const titleText = computed(() =>
  isNew.value ? "Add New BracketExercise" : "Edit BracketExercise",
);

const bracketExerciseForm = ref<VForm>();
const isBracketExerciseValid = useFormValidation(
  bracketExerciseForm,
  modelValue,
);

const selectedExerciseId = ref<number | null>();
const selectedExercise = computed({
  get: () => {
    return exercises.$items.find(
      (e) => e.exerciseId === selectedExerciseId.value,
    );
  },
  set: (value: any) => {
    selectedExerciseId.value = value?.exerciseId;
  },
});
const exercises = new ExerciseListViewModel();
exercises.$load();

async function deleteBracketExercise() {
  await props.bracketExercise.$delete();
  router.push(`/workout/${props.workoutId}`);
}

const isSaving = computed(() => props.bracketExercise.$save.isLoading);

let newExercise = new BracketExerciseViewModel();
newExercise = props.bracketExercise;

async function save() {
  newExercise.exerciseId = selectedExerciseId.value ?? null;
  newExercise.bracketId = props.bracketId;
  await newExercise.$save();
  router.push(`/workout/${props.workoutId}`);
  close();
}

async function cancel() {
  if (props.bracketExercise.bracketExerciseId) {
    await props.bracketExercise.$load();
  }
  close();
}

function close() {
  modelValue.value = false;
}
</script>

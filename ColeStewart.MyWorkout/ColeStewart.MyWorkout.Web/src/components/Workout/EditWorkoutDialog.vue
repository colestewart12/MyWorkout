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
    <v-form ref="workoutForm" v-model="isWorkoutValid" class="mb-3">
      <c-loader-status
        :loaders="{ '': [workout.$save, workout.$delete, workout.$load] }"
      />
      <v-row>
        <v-col cols="6">
          <c-input
            :model="workout"
            for="title"
            label="Workout Title"
            hide-details="auto"
            autofocus
            class="mb-4"
          />
          <c-input
            :model="workout"
            for="description"
            label="Description"
            hide-details="auto"
            multi-line
            class="mb-4"
          />
        </v-col>
      </v-row>
    </v-form>
    <template v-slot:actions>
      <v-btn @click="cancel" color="primary" variant="tonal"> Cancel </v-btn>
      <v-btn
        @click="save"
        :disabled="!isWorkoutValid || isSaving"
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
    title="Delete workout"
    buttonText="Delete"
    buttonColor="error"
    @confirm="deleteworkout"
  >
  </DialogConfirmation>
</template>

<script setup lang="ts">
import router from "@/router";
import { WorkoutViewModel } from "@/viewmodels.g";
import { VForm } from "vuetify/components";
import { useFormValidation } from "@/composables/useFormValidation";

const modelValue = defineModel<boolean>({ default: false });
const dialogOpen = ref(false);

const props = defineProps<{
  workout: WorkoutViewModel;
}>();

const isNew = computed(() => !props.workout?.workoutId);

const titleText = computed(() =>
  isNew.value ? "Add New Workout" : "Edit Workout",
);

const workoutForm = ref<VForm>();
const isWorkoutValid = useFormValidation(workoutForm, modelValue);

async function deleteworkout() {
  await props.workout.$delete();
  router.push("/workout");
}

const isSaving = computed(() => props.workout.$save.isLoading);

async function save() {
  await props.workout.$save();
  // If you want to take to the specific workout page after saving add the id to the route
  router.push("/workout");
  close();
}

async function cancel() {
  if (props.workout.workoutId) {
    await props.workout.$load();
  }
  close();
}

function close() {
  modelValue.value = false;
}
</script>

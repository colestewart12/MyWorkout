<template>
  <Dialog v-model="modelValue" @update:modelValue="cancel" :title="titleText">
    <template v-slot:menuItems v-if="!isNew">
      <v-list-item
        :to="`/admin/audit-logs?type=Exercise&key=${exercise.exerciseId}`"
        target="_blank"
      >
        <template v-slot:prepend>
          <v-icon
            size="small"
            color="primary"
            class="mr-4"
            icon="fas fa-list-timeline"
          />
        </template>
        Audit Logs
      </v-list-item>
      <v-list-item @click="dialogOpen = true">
        <template v-slot:prepend>
          <v-icon size="small" color="error" class="mr-4" icon="fas fa-trash" />
        </template>
        Delete
      </v-list-item>
    </template>
    <v-form ref="exerciseForm" v-model="isExerciseValid" class="mb-3">
      <c-loader-status
        :loaders="{ '': [exercise.$save, exercise.$delete, exercise.$load] }"
      />
      <v-row>
        <v-col cols="6" class="mb-4">
          <c-input
            :model="exercise"
            for="name"
            label="Exercise Name"
            hide-details="auto"
            autofocus
          />
          <c-input
            :model="exercise"
            for="description"
            label="Description"
            hide-details="auto"
            multi-line/>
            <c-input
              :model="exercise"
              for="difficulty"
              label="Difficulty"
              hide-details="auto"/>
        </v-col>
      </v-row>
    </v-form>
    <template v-slot:actions>
      <v-btn @click="cancel" color="primary" variant="tonal"> Cancel </v-btn>
      <v-btn
        @click="save"
        :disabled="!isExerciseValid || isSaving"
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
    title="Delete Exercise"
    buttonText="Delete"
    buttonColor="error"
    @confirm="deleteExercise"
  >
  </DialogConfirmation>
</template>

<script setup lang="ts">
import router from "@/router";
import { ExerciseViewModel } from "@/viewmodels.g";
import { VForm } from "vuetify/components";
import { useFormValidation } from "@/composables/useFormValidation";

const modelValue = defineModel<boolean>({ default: false });
const dialogOpen = ref(false);

const props = defineProps<{
  exercise: ExerciseViewModel;
}>();

const isNew = computed(() => !props.exercise?.exerciseId);

const titleText = computed(() =>
  isNew.value ? "Add New Exercise" : "Edit Exercise",
);

const exerciseForm = ref<VForm>();
const isExerciseValid = useFormValidation(exerciseForm, modelValue);

async function deleteExercise() {
  await props.exercise.$delete();
  router.push("/exercise");
}

const isSaving = computed(() => props.exercise.$save.isLoading);

async function save() {
  await props.exercise.$save();
  // If you want to take to the specific exercise page after saving add the id to the route
  router.push("/exercise");
  close();
}

async function cancel() {
  if (props.exercise.exerciseId) {
    await props.exercise.$load();
  }
  close();
}

function close() {
  modelValue.value = false;
}
</script>

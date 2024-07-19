<template>
  <CardColorBar color="primary" divider>
    <template v-slot:title>
      <div class="d-flex">
        <router-link :to="`/exercise/${exercise.exerciseId}`">
          <h2>{{ exercise.name }}</h2>
        </router-link>
        <v-spacer />
        <v-btn
          @click="editExercise = true"
          color="primary"
          aria-label="Edit exercise"
          icon="fas fa-pencil"
          variant="tonal"
          size="small"
        />
      </div>
      <EditExerciseDialog
        v-model="editExercise"
        :exercise="exercise"
      ></EditExerciseDialog>
      <div>
        {{ exercise.description }}
      </div>
    </template>
  </CardColorBar>
</template>
<script setup lang="ts">
import { ExerciseViewModel } from "@/viewmodels.g";

const props = defineProps<{
  exercise: ExerciseViewModel;
}>();
const editExercise = ref<boolean>(false);
</script>
<template>
  <div>
    <v-card variant="tonal" class="mx-auto my-8" elevation="16" max-width="620">
      <div>
        <v-card-title
          class="exercise-card-title"
          @click="editExercise = true"
          >{{ exercise.name }}</v-card-title
        >
      </div>
    </v-card>
    <EditExerciseDialog
      v-model="editExercise"
      :exercise="exercise"
    ></EditExerciseDialog>
  </div>
</template>

<script setup lang="ts">
import { ExerciseViewModel } from "@/viewmodels.g";

const props = defineProps<{
  exerciseId: number;
}>();

const exercise = new ExerciseViewModel();
exercise.$load(props.exerciseId);

const editExercise = ref<boolean>(false);
</script>

<style>
.exercise-card-title {
  font-size: 24px;
  font-weight: bold;
  text-align: center;
  margin: 0;
  padding: 16px;
  color: "primary";
}
</style>

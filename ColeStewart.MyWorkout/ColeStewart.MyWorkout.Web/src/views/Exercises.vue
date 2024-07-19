<template>
  <v-container>
    <v-row align="center" dense>
      <v-col> <h1>Exercises</h1> </v-col>
      <v-col cols="auto">
        <v-btn
          @click="addExercise = true"
          prepend-icon="fas fa-plus"
          color="primary"
          variant="flat"
        >
          Add Exercise
        </v-btn>
      </v-col>
      <EditExerciseDialog v-model="addExercise" :exercise="newExercise"/>
    </v-row>
    <v-row class="mt-4">
      <v-col v-for="exercise in exercises.$items" :key="exercise.exerciseId!">
        <ExerciseCard :exercise="exercise" />
      </v-col>
    </v-row>
  </v-container>
</template>

<script setup lang="ts">
import { ExerciseListViewModel, ExerciseViewModel } from "@/viewmodels.g";

const exercises = new ExerciseListViewModel();
exercises.$load();
console.log(exercises.$items);

const addExercise = ref<boolean>(false);
const newExercise = new ExerciseViewModel();
</script>

<style>
h1 {
  text-align: center;
}
</style>

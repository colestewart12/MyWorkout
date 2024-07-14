<template>
  <h1>Exercises</h1>
  <v-row class="mt-4">
    <v-col v-for="exercise in exercises.$items" :key="exercise.exerciseId!">
      <ExerciseCard :exercise="exercise" />
    </v-col>
  </v-row>
</template>

<script setup lang="ts">
import ExerciseCard from "@/components/Exercise/ExerciseCard.vue";
import { ExerciseListViewModel } from "@/viewmodels.g";

const exercises = new ExerciseListViewModel();
exercises.$load();
console.log(exercises.$items);
</script>

<style>
h1 {
  text-align: center;
}
</style>

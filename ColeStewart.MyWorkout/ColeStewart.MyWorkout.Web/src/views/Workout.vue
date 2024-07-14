<template>
    <v-container>
    <v-card v-for="workout in workouts.$items" :title="workout.title!"></v-card>
  </v-container>
</template>
<script setup lang="ts">
import { WorkoutListViewModel } from "@/viewmodels.g";
const workouts = new WorkoutListViewModel();

workouts.$load();
console.log(workouts.$items);
</script>
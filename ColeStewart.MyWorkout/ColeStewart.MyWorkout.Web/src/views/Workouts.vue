<template>
  <v-container>
    <v-row align="center" dense>
      <v-col> <h1>Workouts</h1> </v-col>
      <v-col cols="auto">
        <v-btn
          @click="addWorkout = true"
          prepend-icon="fas fa-plus"
          color="primary"
          variant="flat"
        >
          Add Workout
        </v-btn>
      </v-col>
      <EditWorkoutDialog v-model="addWorkout" :workout="newWorkout"/>
    </v-row>
    <v-row class="mt-4">
      <v-col v-for="workout in workouts.$items" :key="workout.workoutId!">
        <WorkoutCard :workout="workout" />
      </v-col>
    </v-row>
  </v-container>
</template>

<script setup lang="ts">
import { WorkoutListViewModel, WorkoutViewModel } from "@/viewmodels.g";

const workouts = new WorkoutListViewModel();
workouts.$load();
console.log(workouts.$items);

const addWorkout = ref<boolean>(false);
const newWorkout = new WorkoutViewModel();
</script>

<style>
h1 {
  text-align: center;
}
</style>

<template>
  <div>
    <v-card variant="tonal" class="mx-auto" elevation="16" max-width="620">
      <div>
        <v-card-title class="workout-card-title" @click="editWorkout = true">
          {{ workout.title }}
        </v-card-title>
      </div>
    </v-card>
    <EditWorkoutDialog
      v-model="editWorkout"
      :workout="workout"
    ></EditWorkoutDialog>
  </div>
</template>

<script setup lang="ts">
import { WorkoutViewModel } from "@/viewmodels.g";

const props = defineProps<{
  workoutId: number;
}>();

const workout = new WorkoutViewModel();
workout.$load(props.workoutId);

const editWorkout = ref<boolean>(false);
</script>

<style>
.workout-card-title {
  font-size: 24px;
  font-weight: bold;
  text-align: center;
  margin: 0;
  padding: 16px;
  color: primary;
}
</style>

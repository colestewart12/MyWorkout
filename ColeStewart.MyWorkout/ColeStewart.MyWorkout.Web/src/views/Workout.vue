<template>
  <div>
    <v-card variant="tonal" class="mx-auto my-8" elevation="16" max-width="620">
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
  <div>
    <v-card
      variant="tonal"
      class="add-bracket-card"
      elevation="16"
      max-width="800"
      @click="addNewBracket"
    >
      <v-icon>mdi-plus</v-icon>
      Add New Bracket
    </v-card>
  </div>
</template>

<script setup lang="ts">
import { WorkoutViewModel } from "@/viewmodels.g";
import { ref } from "vue";

const props = defineProps<{
  workoutId: number;
}>();

const workout = new WorkoutViewModel();
workout.$load(props.workoutId);

const editWorkout = ref<boolean>(false);

const addNewBracket = () => {
  console.log("Add New Bracket clicked");
  // Add your logic for adding a new bracket here
};
</script>

<style>
.workout-card-title {
  font-size: 24px;
  font-weight: bold;
  text-align: center;
  margin: 0;
  padding: 16px;
}

.add-bracket-card {
  display: flex;
  justify-content: center;
  align-items: center;
  font-size: 12px;
  font-weight: bold;
  text-align: center;
  margin: 0;
  padding: 16px;
  color: "primary";
  cursor: pointer;
}
</style>

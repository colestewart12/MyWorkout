<template>
  <div>
    <div>
      <v-card
        variant="tonal"
        class="mx-auto my-8"
        elevation="16"
        max-width="620"
      >
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
    <div class="button-container">
      <v-btn
        color="primary"
        variant="tonal"
        prepend-icon="fas fa-plus"
        @click="editBracket = true"
      >
        Add New Bracket
      </v-btn>
      <EditBracketDialog
        v-model="editBracket"
        :bracket="bracket"
        :workoutId="workoutId"
      ></EditBracketDialog>
    </div>
  </div>
</template>

<script setup lang="ts">
import { WorkoutViewModel, BracketViewModel } from "@/viewmodels.g";
import { ref } from "vue";

const props = defineProps<{
  workoutId: number;
}>();

const workout = new WorkoutViewModel();
workout.$load(props.workoutId);

const bracket = new BracketViewModel();
bracket.workoutId = props.workoutId;

const editWorkout = ref<boolean>(false);
const editBracket = ref<boolean>(false);
</script>

<style>
.workout-card-title {
  font-size: 24px;
  font-weight: bold;
  text-align: center;
  margin: 0;
  padding: 16px;
}

.button-container {
  display: flex;
  justify-content: flex-end;
  margin-top: 16px; /* Add some space above the button if needed */
}
</style>

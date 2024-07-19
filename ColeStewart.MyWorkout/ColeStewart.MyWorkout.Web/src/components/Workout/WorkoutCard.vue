<template>
  <CardColorBar color="primary" divider>
    <template v-slot:title>
      <div class="d-flex">
        <router-link :to="`/workout/${workout.workoutId}`">
          <h2>{{ workout.title }}</h2>
        </router-link>
        <v-spacer />
        <v-btn
          @click="editWorkout = true"
          color="primary"
          aria-label="Edit workout"
          icon="fas fa-pencil"
          variant="tonal"
          size="small"
        />
      </div>
      <EditWorkoutDialog
        v-model="editWorkout"
        :workout="workout"
      ></EditWorkoutDialog>
      <div>
        {{ workout.description }}
      </div>
    </template>
  </CardColorBar>
</template>
<script setup lang="ts">
import { WorkoutViewModel } from "@/viewmodels.g";

const props = defineProps<{
  workout: WorkoutViewModel;
}>();
const editWorkout = ref<boolean>(false);
</script>

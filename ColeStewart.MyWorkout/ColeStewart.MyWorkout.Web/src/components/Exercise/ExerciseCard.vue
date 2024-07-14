<template>
  <CardColorBar color="primary" divider>
    <template v-slot:title>
      <div class="d-flex">
        <h2 class="wrap-break">{{ exercise.name }}</h2>
        <v-spacer />
        <v-btn
          color="primary"
          aria-label="Edit exercise"
          icon="fas fa-pencil"
          variant="tonal"
          size="small"
        />
      </div>
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
</script>

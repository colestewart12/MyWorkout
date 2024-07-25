<template>
  <CardColorBar color="primary" divider>
    <template v-slot:title>
      <div class="d-flex">
        <router-link :to="`/workout/${workoutId}`">
          <h2>{{ bracket.bracketName }}</h2>
        </router-link>
        <v-spacer />
        <v-btn
          @click="editBracket = true"
          color="primary"
          aria-label="Edit bracket"
          icon="fas fa-pencil"
          variant="tonal"
          size="small"
        />
      </div>
      <EditBracketDialog
        v-model="editBracket"
        :bracket="bracket"
        :workoutId="workoutId"
      ></EditBracketDialog>
    </template>
    <div>
      <v-btn
        block
        color="primary"
        variant="tonal"
        class="my-8"
        prepend-icon="fas fa-plus"
        @click="editBracketExercise = true"
      >
        Add Exercise</v-btn
      >
      <EditBracketExerciseDialog
        v-model="editBracketExercise"
        :bracketExercise="bracketExercise"
        :bracketId="bracket.bracketId!"
        :workoutId="workoutId"
      ></EditBracketExerciseDialog>
    </div>
  </CardColorBar>
</template>
<script setup lang="ts">
import { BracketViewModel, BracketExerciseViewModel } from "@/viewmodels.g";
import EditBracketDialog from "./EditBracketDialog.vue";

const props = defineProps<{
  bracket: BracketViewModel;
  workoutId: number;
}>();
const editBracket = ref<boolean>(false);

const editBracketExercise = ref<boolean>(false);
const bracketExercise = new BracketExerciseViewModel();
</script>

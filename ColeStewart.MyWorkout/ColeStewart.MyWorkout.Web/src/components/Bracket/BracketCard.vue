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
  </CardColorBar>
</template>
<script setup lang="ts">
import { BracketViewModel } from "@/viewmodels.g";

const props = defineProps<{
  bracket: BracketViewModel;
  workoutId: number;
}>();
const editBracket = ref<boolean>(false);
</script>

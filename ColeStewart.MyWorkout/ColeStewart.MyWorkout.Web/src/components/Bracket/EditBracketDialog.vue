<template>
  <Dialog v-model="modelValue" @update:modelValue="cancel" :title="titleText">
    <template v-slot:menuItems v-if="!isNew">
      <v-list-item @click="dialogOpen = true">
        <template v-slot:prepend>
          <v-icon size="small" color="error" class="mr-4" icon="fas fa-trash" />
        </template>
        Delete
      </v-list-item>
    </template>
    <v-form ref="bracketForm" v-model="isBracketValid" class="mb-3">
      <c-loader-status
        :loaders="{ '': [bracket.$save, bracket.$delete, bracket.$load] }"
      />
      <v-row>
        <v-col cols="6">
          <c-input
            :model="bracket"
            for="bracketName"
            label="Bracket Name"
            hide-details="auto"
            autofocus
            class="mb-4"
          />
        </v-col>
      </v-row>
    </v-form>
    <template v-slot:actions>
      <v-btn @click="cancel" color="primary" variant="tonal"> Cancel </v-btn>
      <v-btn
        @click="save"
        :disabled="!isBracketValid || isSaving"
        :loading="isSaving"
        color="primary"
        variant="flat"
        type="submit"
      >
        Save
      </v-btn>
    </template>
  </Dialog>
  <DialogConfirmation
    v-model="dialogOpen"
    title="Delete Bracket"
    buttonText="Delete"
    buttonColor="error"
    @confirm="deleteBracket"
  >
  </DialogConfirmation>
</template>

<script setup lang="ts">
import router from "@/router";
import { BracketViewModel } from "@/viewmodels.g";
import { VForm } from "vuetify/components";
import { useFormValidation } from "@/composables/useFormValidation";

const modelValue = defineModel<boolean>({ default: false });
const dialogOpen = ref(false);

const props = defineProps<{
  bracket: BracketViewModel;
  workoutId: number;
}>();

const isNew = computed(() => !props.bracket?.bracketId);

const titleText = computed(() =>
  isNew.value ? "Add New Bracket" : "Edit Bracket",
);

const bracketForm = ref<VForm>();
const isBracketValid = useFormValidation(bracketForm, modelValue);

async function deleteBracket() {
  await props.bracket.$delete();
  router.push(`/workout/${props.workoutId}`);
}

const isSaving = computed(() => props.bracket.$save.isLoading);

async function save() {
  await props.bracket.$save();
  // If you want to take to the specific bracket page after saving add the id to the route
  router.push(`/workout/${props.workoutId}`);
  close();
}

async function cancel() {
  if (props.bracket.bracketId) {
    await props.bracket.$load();
  }
  close();
}

function close() {
  modelValue.value = false;
}
</script>

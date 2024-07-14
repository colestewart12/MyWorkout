<template>
  <v-dialog v-model="modelValue" max-width="350px">
    <v-col cols="12">
      <v-card max-width="350px">
        <v-card-item>
          <v-card-title class="wrap-break">
            {{ title }}
          </v-card-title>
        </v-card-item>
        <v-card-actions class="pa-6">
          <v-spacer />
          <v-btn
            @click="modelValue = false"
            @keydown.enter="cancelOnEnter"
            variant="tonal"
          >
            Cancel
          </v-btn>
          <v-btn
            @keydown.enter="confirmOnEnter"
            :color="buttonColor"
            @click="confirm()"
            variant="elevated"
          >
            {{ buttonText }}
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-col>
  </v-dialog>
</template>

<script lang="ts" setup>
withDefaults(
  defineProps<{
    title?: string;
    buttonText?: string;
    description?: string;
    buttonColor?: string;
  }>(),
  {
    title: "Are you sure?",
    buttonText: "Ok",
    buttonColor: "primary",
  },
);
const emit = defineEmits(["confirm"]);

const modelValue = defineModel<boolean>();

function confirm() {
  modelValue.value = false;
  emit("confirm");
}

function confirmOnEnter(e: KeyboardEvent) {
  e.stopPropagation();
  e.preventDefault();
  confirm();
}

function cancelOnEnter(e: KeyboardEvent) {
  e.stopPropagation();
  e.preventDefault();
  modelValue.value = false;
}
</script>

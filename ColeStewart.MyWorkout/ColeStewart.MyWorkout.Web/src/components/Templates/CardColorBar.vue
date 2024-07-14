<template>
  <v-card
    :border="true"
    class="overflow-visible d-flex flex-column"
    variant="flat"
    height="100%"
    rounded="0"
  >
    <div class="card-top-right-icons">
      <slot name="corner-icons" />
    </div>
    <v-sheet :color="color" height="8px" />
    <v-card-item v-if="$slots.title">
      <slot name="title" />
    </v-card-item>
    <v-divider v-if="divider" />
    <v-card-text v-if="$slots.default">
      <slot />
    </v-card-text>
    <slot name="default-no-padding" />

    <v-divider v-if="$slots.actions && $slots.default" />
    <v-card-text v-if="$slots.actions" class="flex-grow-0">
      <slot name="actions" />
    </v-card-text>
  </v-card>
</template>

<script lang="ts" setup>
withDefaults(
  defineProps<{
    color?: string;
    divider?: boolean;
  }>(),
  {
    color: "primary",
    divider: false,
  },
);
</script>

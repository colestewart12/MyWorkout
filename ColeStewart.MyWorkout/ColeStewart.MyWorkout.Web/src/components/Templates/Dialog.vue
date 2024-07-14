<template>
  <v-dialog
    :max-width="fullscreen ? undefined : '800px'"
    scrollable
    :fullscreen="fullscreen"
  >
    <v-card>
      <v-card-item class="bg-primary pt-4 pb-3">
        <v-row>
          <v-col :cols="$slots.menuItems ? '9' : '12'" class="my-auto">
            <slot name="title">
              <v-card-title> {{ title }} </v-card-title>
              <v-card-subtitle> {{ subtitle }} </v-card-subtitle>
            </slot>
          </v-col>
          <v-spacer />
          <v-col v-if="$slots.menuItems" cols="3" class="text-right">
            <v-menu location="bottom right">
              <template v-slot:activator="{ props }">
                <v-btn
                  icon="fas fa-ellipsis-vertical"
                  variant="text"
                  v-bind="props"
                  density="comfortable"
                >
                </v-btn>
              </template>
              <v-list class="pa-1">
                <slot name="menuItems" />
              </v-list>
            </v-menu>
          </v-col>
        </v-row>
      </v-card-item>
      <v-card-text v-if="$slots.default" class="py-4">
        <slot />
      </v-card-text>
      <v-divider v-if="$slots.default && $slots.actions" />
      <v-card-actions class="pa-6">
        <v-spacer />
        <slot name="actions" />
      </v-card-actions>
    </v-card>
  </v-dialog>
</template>

<script setup lang="ts">
defineProps<{
  title?: string;
  subtitle?: string;
  fullscreen?: boolean;
}>();
</script>

<template>
  <v-container>
    <v-card v-for="u in user.$items" :key="u.userId!" :title="u.name!"></v-card>
  </v-container>
</template>

<script setup lang="ts">
import { UserListViewModel } from "@/viewmodels.g";
const user = new UserListViewModel();

user.$load();
console.log(user.$items);
</script>

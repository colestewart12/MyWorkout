<template>
    <dl>
      <dt>Name</dt>
      <dd>
        <c-display :model="user" for="name" />
      </dd>
  
      <dt>Date of Birth</dt>
      <dd>
        <c-display :model="user" for="birthDate" format="M/d/yyyy" />
      </dd>
    </dl>
  </template>
  
  <script setup lang="ts"> 
  import { UserViewModel } from "@/viewmodels.g";
  
  const props = defineProps<{ id: number }>();
  const user = new UserViewModel();
  
  user.$load(props.id);
  </script>
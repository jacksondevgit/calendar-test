<template>
  <div class="q-pa-md">
    <q-date v-model="date" :events="events" />
  </div>
</template>

<script setup lang="ts">
import { ref, onMounted } from 'vue'

// Define reactive state
const date = ref(new Date().toISOString().slice(0, 10))
const events = ref([])

onMounted(async () => {
  try {
    const response = await fetch(
      'https://localhost:7260/api/calendar/getevents',
    )

    if (!response.ok) {
      throw new Error(`HTTP error! Status: ${response.status}`)
    }

    const data = await response.json()
    events.value = data.map((event) => event.scheduleString)
  } catch (err) {
  } finally {
  }
})
</script>

<style scoped></style>

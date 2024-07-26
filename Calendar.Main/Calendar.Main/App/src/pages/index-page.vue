<template>
  <div class="q-pa-md">
    <q-date v-model="date" :events="events" />
  </div>
</template>

<script setup lang="ts">
import { ref, onMounted } from 'vue'

// Define reactive state
const date = ref('2019/02/01')
const events = ref([
  '2019/02/01',
  '2019/02/05',
  '2019/02/06',
  '2019/02/09',
  '2019/02/23',
])

onMounted(async () => {
  try {
    const response = await fetch(
      'https://localhost:7260/api/calendar/getevents',
    )

    if (!response.ok) {
      throw new Error(`HTTP error! Status: ${response.status}`)
    }

    console.log(response)
  } catch (err) {
  } finally {
  }
})
</script>

<style scoped></style>

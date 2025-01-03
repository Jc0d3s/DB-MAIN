<script lang="ts">
import { defineComponent } from 'vue';

export default defineComponent({
  name: 'ContactInfoBar',
});
</script>

<template>
  <div class="bg-[#2B3B5C] text-white text-sm py-4">
    <div class="container mx-auto px-4">
      <div class="flex flex-col md:flex-row justify-between items-center space-y-4 md:space-y-0">
        <div class="flex flex-col md:flex-row md:space-x-16">
          <span class="flex items-center space-x-2">
            <i class="fas fa-map-marker-alt text-[#fdd428]"></i>
            <span>1010 Avenue, New York, NY 10018 US.</span>
          </span>
          <span class="flex items-center space-x-2 mt-2 md:mt-0">
            <i class="fa fa-phone-alt text-[#fdd428] transform rotate-90"></i>
            <span>212 386 5575, 212 386 5576</span>
          </span>
        </div>
        <span class="flex items-center space-x-2">
          <i class="far fa-clock text-[#fdd428]"></i>
          <span>Mon-Sat, 8.00-18.00. Sunday CLOSED</span>
        </span>
      </div>
    </div>
  </div>
</template>



<style scoped>
/* Adjustments for mobile responsiveness */
@media (max-width: 768px) {
  .container {
    padding: 0 1rem; /* Add extra padding for smaller screens */
  }
  .text-sm {
    font-size: 0.875rem; /* Adjust font size for better readability */
  }
}
</style>

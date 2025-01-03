<script setup>
import { ref } from 'vue';

const quickLinks = ref([
  { text: "Contact Us", href: "#" },
  { text: "FAQ", href: "#" },
  { text: "Privacy Policy", href: "#" },
  { text: "Terms of Use", href: "#" },
]);

const socialLinks = ref([
  { text: "LinkedIn", href: "#", icon: "fab fa-linkedin" },
  { text: "Twitter", href: "#", icon: "fab fa-twitter" },
]);
</script>


<template>
  <footer class="bg-blue-900 text-white py-8">
    <div class="container mx-auto px-4">
      <div class="flex flex-wrap justify-between">
        <!-- Signup Section -->
        <div class="w-full lg:w-1/3 mb-8 lg:mb-0">
          <h2 class="text-xl sm:text-2xl font-bold">Sign up for email alerts</h2>
          <p class="mt-2 text-sm">Stay current with our latest insights</p>
          <div class="mt-4 flex flex-col sm:flex-row">
            <input
              type="email"
              placeholder="Enter Email Here"
              class="flex-grow px-4 py-2 rounded-t-md sm:rounded-t-none sm:rounded-l-md text-gray-800"
            />
            <button
              class="bg-yellow-500 text-black px-4 py-2 rounded-b-md sm:rounded-b-none sm:rounded-r-md hover:bg-yellow-600"
            >
              Submit
            </button>
          </div>
        </div>

        <!-- Links Section -->
        <div class="w-full sm:w-1/2 lg:w-1/5 mb-8 lg:mb-0">
          <h3 class="font-bold text-lg mb-4">Quick Links</h3>
          <ul>
            <li v-for="(link, index) in quickLinks" :key="index" class="mb-2">
              <a :href="link.href" class="hover:underline">{{ link.text }}</a>
            </li>
          </ul>
        </div>

        <!-- Social Media Section -->
        <div class="w-full sm:w-1/2 lg:w-1/5">
          <h3 class="font-bold text-lg mb-4">Follow Us</h3>
          <ul>
            <li v-for="(social, index) in socialLinks" :key="index" class="mb-2 flex items-center">
              <i :class="social.icon" class="mr-2"></i>
              <a :href="social.href" class="hover:underline">{{ social.text }}</a>
            </li>
          </ul>
        </div>
      </div>

      <!-- Footer Bottom -->
      <div class="mt-8 text-center text-sm">
        <p>© 2023 Elixir Inc. All rights reserved. Designed by Kamisama.</p>
      </div>
    </div>
  </footer>
</template>



<style scoped>
/* Optional: Add any additional styling if needed */
</style>

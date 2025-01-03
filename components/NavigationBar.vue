<script lang="ts">
import { ref } from 'vue';

export default {
  name: 'NavigationBar',
  setup() {
    const isMobileMenuOpen = ref(false);

    const toggleMobileMenu = () => {
      isMobileMenuOpen.value = !isMobileMenuOpen.value;
    };

    return { isMobileMenuOpen, toggleMobileMenu };
  },
};
</script>

<template>
  <nav class="bg-white bg-opacity-50 shadow-md sticky top-0 z-50 backdrop-blur-sm">
    <div class="container mx-auto px-4">
      <div class="flex items-center justify-between">
        <!-- Logo -->
        <div class="py-4 mr-4 ml-4 lg:ml-12">
          <img src="/assets/logo-dark.png" alt="Elixir" class="h-8 ml-4">
        </div>

        <!-- Mobile Menu Button -->
        <button 
          class="lg:hidden text-[#2B3B5C] focus:outline-none" 
          @click="toggleMobileMenu"
        >
          <i class="fas" :class="isMobileMenuOpen ? 'fa-times' : 'fa-bars'"></i>
        </button>

        <!-- Navigation Links -->
        <div 
          :class="{
            'hidden': !isMobileMenuOpen,
            'lg:flex': true,
            'flex-col': true,
            'lg:flex-row': true,
            'lg:items-center': true,
            'gap-8': true,
            'w-full': true,
            'lg:w-auto': true,
            'bg-white': true,
            'lg:bg-transparent': true,
            'lg:shadow-none': true,
            'shadow-lg': true,
            'p-4': true,
            'lg:p-0': true,
            'absolute': true,
            'lg:relative': true,
            'top-full': true,
            'left-0': true,
            'lg:top-auto': true,
            'lg:left-auto': true,
            'lg:right-56': true
          }"
        >
          <!-- Home Dropdown -->
          <div class="group relative">
            <button class="py-2 lg:py-4 flex items-center">
              <span class="font-semibold">Home</span>
              <i class="fas fa-chevron-down ml-1"></i>
            </button>
            <div class="hidden group-hover:block absolute top-full left-0 mt-2 bg-white shadow-lg border border-gray-200 rounded-md">
              <a href="#" class="block px-6 py-2 text-sm hover:bg-gray-100 whitespace-nowrap">Slider Header</a>
              <a href="#" class="block px-6 py-2 text-sm hover:bg-gray-100 whitespace-nowrap">Static Header</a>
              <a href="#" class="block px-6 py-2 text-sm hover:bg-gray-100 whitespace-nowrap">Youtube Background</a>
              <a href="#" class="block px-6 py-2 text-sm hover:bg-gray-100 whitespace-nowrap">Self-hosted Video</a>
            </div>
          </div>

          <!-- Pages Dropdown -->
          <div class="group relative">
            <button class="py-2 lg:py-4 flex items-center">
              <span class="font-semibold">Pages</span>
              <i class="fas fa-chevron-down ml-1"></i>
            </button>
            <div class="hidden group-hover:block absolute top-full left-0 mt-2 bg-white shadow-lg border border-gray-200 rounded-md">
              <a href="#" class="block px-6 py-2 text-sm hover:bg-gray-100 whitespace-nowrap">Services</a>
              <a href="#" class="block px-6 py-2 text-sm hover:bg-gray-100 whitespace-nowrap">About</a>
              <a href="#" class="block px-6 py-2 text-sm hover:bg-gray-100 whitespace-nowrap">Login</a>
              <a href="#" class="block px-6 py-2 text-sm hover:bg-gray-100 whitespace-nowrap">Registration</a>
            </div>
          </div>

          <!-- News Dropdown -->
          <div class="group relative">
            <button class="py-2 lg:py-4 flex items-center">
              <span class="font-semibold">News</span>
              <i class="fas fa-chevron-down ml-1"></i>
            </button>
            <div class="hidden group-hover:block absolute top-full left-0 mt-2 bg-white shadow-lg border border-gray-200 rounded-md">
              <a href="#" class="block px-6 py-2 text-sm hover:bg-gray-100 whitespace-nowrap">Newsroom</a>
              <a href="#" class="block px-6 py-2 text-sm hover:bg-gray-100 whitespace-nowrap">Single News</a>
            </div>
          </div>

          <!-- Elements Dropdown -->
          <div class="group relative">
            <button class="py-2 lg:py-4 flex items-center">
              <span class="font-semibold">Elements</span>
              <i class="fas fa-chevron-down ml-1"></i>
            </button>
            <div class="hidden group-hover:block absolute top-full left-0 mt-2 bg-white shadow-lg border border-gray-200 rounded-md">
              <a href="#" class="block px-6 py-2 text-sm hover:bg-gray-100 whitespace-nowrap">Buttons</a>
              <a href="#" class="block px-6 py-2 text-sm hover:bg-gray-100 whitespace-nowrap">Colors</a>
              <a href="#" class="block px-6 py-2 text-sm hover:bg-gray-100 whitespace-nowrap">Grid</a>
              <a href="#" class="block px-6 py-2 text-sm hover:bg-gray-100 whitespace-nowrap">Typography</a>
            </div>
          </div>

          <!-- Contact Link -->
          <a href="#" class="font-semibold py-2 lg:py-4">Contact</a>
        </div>

        <!-- Purchase Button -->
        <button class="hidden lg:block border-2 border-[#2B3B5C] text-[#2B3B5C] px-4 py-1 rounded-full hover:bg-[#2B3B5C] hover:text-white transition-colors font-montserrat-16px text-[16px] font-semibold">
          Purchase
        </button>
      </div>
    </div>
  </nav>
</template>



<style scoped>
/* Dropdown visibility */
.group-hover > div {
  display: block;
}
</style>

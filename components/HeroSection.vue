<script setup lang="ts">
import { ref, onMounted, onBeforeUnmount, nextTick } from 'vue';
import { gsap } from 'gsap';

// Define the structure of a Header using an interface
interface Header {
  image: string;
  title: string;
  description: string;
}

// List of header data
const headers = ref<Header[]>([
  {
    image: '/assets/header-5.jpg',
    title: 'Expert Consultants',
    description: 'Over 10 years of experience in helping clients<br>find comprehensive solutions.',
  },
  {
    image: '/assets/header-1.jpg',
    title: 'Growth Partners',
    description: 'Connect with top consultants hand-picked by<br> Elixir consulting and finance.',
  },
  {
    image: '/assets/header-6.jpg',
    title: 'Helping Leaders',
    description: 'We look forward to helping you in taking <br>your company to new heights.',
  },
]);

const currentHeader = ref(0);

// Functions to navigate between headers
const nextHeader = () => {
  currentHeader.value = (currentHeader.value + 1) % headers.value.length;
  animateContent(); // Trigger animation on next slide
};

const previousHeader = () => {
  currentHeader.value = (currentHeader.value - 1 + headers.value.length) % headers.value.length;
  animateContent(); // Trigger animation on previous slide
};

// GSAP animation function
const animateContent = () => {
  nextTick(() => {
    // Animate title, description, and buttons
    gsap.from('.fade-up', {
      opacity: 0,
      y: 30,
      duration: 2.0,
      ease: 'power3.out',
      stagger: 0.2, // Adds a delay between animations
       // Resets properties to avoid conflicts
    });

    // Specific animation for buttons
    gsap.from('.button-fade', {
      opacity: 0,
      y: 30,
      duration: 2.0,
      ease: 'power3.out',
      stagger: 0.2, // Adds a delay between animations
      clearProps: 'all', // Resets properties to avoid conflicts
    });
  });
};




// Auto-slide functionality
let autoSlide: ReturnType<typeof setInterval>;
onMounted(() => {
  autoSlide = setInterval(nextHeader, 4000);
  animateContent(); // Initial animation
});

onBeforeUnmount(() => {
  clearInterval(autoSlide);
});
</script>

<template>
  <div class="relative -mt-12 z-10">
    <!-- Background Slider -->
    <img
      class="w-full h-full object-cover -mt-16 transition-all duration-500"
      :src="headers[currentHeader].image"
      alt="Header Image"
    />

    <!-- Header Content -->
    <div
      class="absolute inset-0 flex flex-wrap items-start justify-start text-black p-8 mt-24 ml-16 lg:mt-24 lg:ml-16 sm:mt-12 sm:ml-6"
    >
      <div class="max-w-full">
        <!-- Title -->
        <h1
          v-if="headers[currentHeader]"
          :key="`header-title-${currentHeader}`"
          class="fade-up text-[#2A3855] text-[67.34px] sm:text-[36px] font-bold mb-2"
          style="font-family: 'Montserrat', sans-serif; line-height: 1.2;"
        >
          {{ headers[currentHeader].title }}
        </h1>

        <!-- Description -->
        <p
          v-if="headers[currentHeader]"
          :key="`header-description-${currentHeader}`"
          class="fade-up color-primary mt-4 mb-5 lh-2 fs-1 fs-md-2"
          style="font-family: 'Open Sans', sans-serif; line-height: 1.4;"
          v-html="headers[currentHeader].description"
        ></p>

        <!-- Buttons -->
        <div>
          <a
  href="#learn-more"
  :key="`learn-more-${currentHeader}`"
  class=" bg-[#00274D] text-white font-semibold px-8 py-3 sm:px-4 sm:py-2 rounded-lg shadow-md hover:bg-[#001F3A] transition duration-200 mr-3"
>
  Learn More
</a>
<a
  href="#contact-us"
  :key="`contact-us-${currentHeader}`"
  class=" bg-[#ffc107] text-[#212529] font-semibold px-8 py-3 sm:px-4 sm:py-2 rounded-lg shadow-md hover:bg-[#e0a800] transition duration-200"
>
  Contact Us
</a>


        </div>
      </div>
    </div>

    <!-- Navigation Buttons -->
    <div
      class="absolute top-1/2 left-4 transform -translate-y-1/2 bg-none text-black w-15 h-15 rounded-full flex items-center justify-center cursor-pointer"
      @click="previousHeader"
    >
      <i class="fas fa-chevron-left"></i>
    </div>
    <div
      class="absolute top-1/2 right-4 transform -translate-y-1/2 bg-none text-black w-15 h-15 rounded-full flex items-center justify-center cursor-pointer"
      @click="nextHeader"
    >
      <i class="fas fa-chevron-right"></i>
    </div>
  </div>
</template>

<style scoped>
/* Default Styles */
h1 {
  font-size: 72px;
  line-height: 1.2;
}

p {
  font-size: 32px;
  line-height: 1.4;
}

/* Buttons */
a {
  font-size: 16px;
  padding: 0.75rem 1.25rem;
}

/* Responsive Styles */
@media (max-width: 768px) {
  h1 {
    font-size: 48px;
  }
  p {
    font-size: 24px;
  }
  a {
    font-size: 14px;
  }
}

@media (max-width: 480px) {
  h1 {
    font-size: 28px;
  }
  p {
    font-size: 16px;
  }
  a {
    font-size: 14px;
    padding: 0.5rem 1rem;
  }
}
</style>

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
        <transition-group 
          name="pop-up" 
          tag="div"
        >
          <h1
            v-if="headers[currentHeader]"
            :key="`header-title-${currentHeader}`"
            class="text-[#2A3855] text-[67.34px] sm:text-[36px] font-bold mb-2"
            style="font-family: 'Montserrat', sans-serif; line-height: 1.2;"
          >
            {{ headers[currentHeader].title }}
          </h1>
        </transition-group>

        <!-- Description -->
        <transition-group 
          name="pop-up" 
          tag="div"
        >
          <p
            v-if="headers[currentHeader]"
            :key="`header-description-${currentHeader}`"
            class="text-[#2A3855] text-[28.43px] sm:text-[18px] mb-12"
            style="font-family: 'Open Sans', sans-serif; line-height: 1.4;"
            v-html="headers[currentHeader].description"
          ></p>
        </transition-group>

        <!-- Buttons -->
        <div>
          <a 
            href="#learn-more" 
            class="bg-[#00274D] text-white font-semibold px-8 py-3 sm:px-4 sm:py-2 rounded-lg shadow-md hover:bg-[#001F3A] transition duration-200 mr-3"
          >
            Learn More
          </a>
          <a 
            href="#contact-us" 
            class="bg-[#ffc107] text-[#212529] font-semibold px-8 py-3 sm:px-4 sm:py-2 rounded-lg shadow-md hover:bg-[#e0a800] transition duration-200"
          >
            Contact Us
          </a>
        </div>
      </div>
    </div>

    <!-- Navigation Buttons -->
    <div 
      class="absolute top-1/2 left-4 transform -translate-y-1/2 bg-gray-800 text-white w-10 h-10 rounded-full flex items-center justify-center cursor-pointer"
      @click="previousHeader"
    >
      <i class="fas fa-chevron-left"></i>
    </div>
    <div 
      class="absolute top-1/2 right-4 transform -translate-y-1/2 bg-gray-800 text-white w-10 h-10 rounded-full flex items-center justify-center cursor-pointer"
      @click="nextHeader"
    >
      <i class="fas fa-chevron-right"></i>
    </div>
  </div>
</template>

<script lang="ts">
import { ref, onMounted, onBeforeUnmount, defineComponent } from 'vue';

type Header = {
  image: string;
  title: string;
  description: string;
};

export default defineComponent({
  name: 'HeroSection',
  setup() {
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

    const currentHeader = ref<number>(0);

    const nextHeader = () => {
      currentHeader.value = (currentHeader.value + 1) % headers.value.length;
    };

    const previousHeader = () => {
      currentHeader.value = (currentHeader.value - 1 + headers.value.length) % headers.value.length;
    };

    let autoSlide: ReturnType<typeof setInterval>;
    onMounted(() => {
      autoSlide = setInterval(nextHeader, 4000);
    });

    onBeforeUnmount(() => {
      clearInterval(autoSlide);
    });

    return {
      headers,
      currentHeader,
      nextHeader,
      previousHeader,
    };
  },
});
</script>

<style scoped>
/* Default Styles */
h1 {
  font-size: 72px; /* Larger font size for desktop screens */
  line-height: 1.2;
}

p {
  font-size: 32px; /* Larger description font size */
  line-height: 1.4;
}

a {
  font-size: 16px; /* Button text size */
  padding: 0.75rem 1.25rem;
}

/* Adjustments for tablet screens */
@media (max-width: 768px) {
  h1 {
    font-size: 48px; /* Larger font size for tablets */
  }
  p {
    font-size: 24px; /* Larger description font size for tablets */
  }
  a {
    font-size: 14px; /* Adjust button text size for tablets */
  }
}

/* Adjustments for mobile screens */
@media (max-width: 480px) {
  h1 {
    font-size: 28px; /* Reduced font size for better fit */
    line-height: 1.2; /* Ensure line height works for wrapping */
  }
  p {
    font-size: 16px; /* Reduced description font size */
    line-height: 1.4; /* Improved readability */
  }
  .absolute.inset-0 {
    padding: 1rem; /* Add padding for mobile view */
    margin-top: 2rem; /* Add margin to prevent overlap with previous section */
  }
  .text-black {
    max-width: 100%; /* Prevent text from overflowing */
    word-wrap: break-word; /* Ensure words break properly */
  }
  a {
    font-size: 14px; /* Same button text size as tablets */
    padding: 0.5rem 1rem; /* Adjust button padding for mobile */
  }
}

/* Z-Index to Fix Overlap Issues */
.relative {
  z-index: 10; /* Ensure the hero section appears above other content */
}
</style>
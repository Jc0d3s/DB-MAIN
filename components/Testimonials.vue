<template>
  <div>
    <!-- Hero Section -->
    <div class="relative bg-gray-800 text-white h-screen">
      <!-- Background Section -->
      <div class="absolute inset-0">
        <img
          class="w-full h-full object-cover opacity-50"
          src="/assets/background-15.jpg"
          alt="Background"
        />
      </div>

      <!-- Content Section -->
      <div class="relative z-10 flex flex-col items-center justify-center h-full text-center px-4 sm:px-8 lg:px-16">
        <h1 class="text-3xl sm:text-4xl lg:text-6xl font-bold mb-8">
          <ion-icon name="checkmark-done-outline" class="text-yellow-400 align-middle mr-2"></ion-icon>
          Take the <span class="text-yellow-400">right step</span>,<br />
          do the big things.
        </h1>

        <!-- Stats Section -->
        <div class="grid grid-cols-2 md:grid-cols-4 gap-4 sm:gap-6 mb-8">
          <div class="text-center">
            <p class="text-2xl sm:text-3xl font-bold">52k</p>
            <p class="text-gray-300 text-sm sm:text-base">Cases Solved</p>
          </div>
          <div class="text-center">
            <p class="text-2xl sm:text-3xl font-bold">164</p>
            <p class="text-gray-300 text-sm sm:text-base">Trained Experts</p>
          </div>
          <div class="text-center">
            <p class="text-2xl sm:text-3xl font-bold">38</p>
            <p class="text-gray-300 text-sm sm:text-base">Branches</p>
          </div>
          <div class="text-center">
            <p class="text-2xl sm:text-3xl font-bold">100%</p>
            <p class="text-gray-300 text-sm sm:text-base">Satisfied Clients</p>
          </div>
        </div>
      </div>
    </div>

    <!-- Testimonial Section -->
    <div class="relative max-w-6xl mx-auto p-4 sm:p-8 bg-white shadow-lg rounded-lg mt-16">
      <!-- Testimonial Content -->
      <div
        v-for="(testimonial, index) in testimonials"
        :key="index"
        class="flex flex-col sm:flex-row items-center space-y-4 sm:space-y-0 sm:space-x-6"
        v-show="currentIndex === index"
      >
        <!-- Image -->
        <img
          class="w-24 h-24 sm:w-32 sm:h-32 lg:w-48 lg:h-48 rounded-full object-cover"
          :src="testimonial.image"
          alt="Profile Picture"
        />
        <!-- Text -->
        <div class="text-center sm:text-left">
          <p class="text-gray-700 text-sm sm:text-base lg:text-lg">{{ testimonial.quote }}</p>
          <p class="mt-2 font-bold text-gray-900">{{ testimonial.name }}</p>
          <p class="text-xs sm:text-sm text-gray-500">{{ testimonial.position }}</p>
        </div>
      </div>

      <!-- Navigation Arrows -->
      <button
        class="absolute left-4 top-1/2 transform -translate-y-1/2 bg-transparent text-gray-800 p-3 rounded-full shadow-md hover:bg-gray-300 focus:outline-none"
        @click="prevTestimonial"
        aria-label="Previous Testimonial"
      >
        <span class="text-2xl sm:text-3xl">&#10094;</span>
      </button>
      <button
        class="absolute right-4 top-1/2 transform -translate-y-1/2 bg-transparent text-gray-800 p-3 rounded-full shadow-md hover:bg-gray-300 focus:outline-none"
        @click="nextTestimonial"
        aria-label="Next Testimonial"
      >
        <span class="text-2xl sm:text-3xl">&#10095;</span>
      </button>
    </div>
  </div>
</template>

<script>
export default {
  name: "TestimonialSection",
  data() {
    return {
      currentIndex: 0,
      testimonials: [
        {
          image: "/assets/client1.png",
          quote:
            "As a sales gamification company, we were skeptical to work with a consultant to optimize our sales emails, but Elixir was highly recommended by many other Y-Combinator startups we knew.",
          name: "David Beckham",
          position: "Chairman, Harmony Corporation",
        },
        {
          image: "/assets/client2.png",
          quote:
            "Writing case studies was a daunting task for us. We didn’t know where to begin or what questions to ask. Elixir team did everything with almost no effort from me!",
          name: "Maria Sharapova",
          position: "Managing Director, Themewagon Inc.",
        },
        {
          image: "/assets/client3.png",
          quote:
            "Their work on our website and Internet marketing has made a significant difference to our business. We've seen a 425% increase in quote requests from the website which has been pretty remarkable - but I'd always like to see more!",
          name: "Michael Clarke",
          position: "CEO, A.E.T Institute",
        },
      ],
      intervalId: null, // ID for the interval
    };
  },
  methods: {
    prevTestimonial() {
      this.currentIndex =
        (this.currentIndex - 1 + this.testimonials.length) % this.testimonials.length;
    },
    nextTestimonial() {
      this.currentIndex = (this.currentIndex + 1) % this.testimonials.length;
    },
    startAutoCycle() {
      this.intervalId = setInterval(() => {
        this.nextTestimonial();
      }, 4000); // Switch slides every 4 seconds
    },
    stopAutoCycle() {
      if (this.intervalId) {
        clearInterval(this.intervalId);
        this.intervalId = null;
      }
    },
  },
  mounted() {
    this.startAutoCycle(); // Start auto-cycling on component mount
  },
  beforeDestroy() {
    this.stopAutoCycle(); // Clear the interval when component is destroyed
  },
};
</script>


<style scoped>
/* General Styles */
.icon {
  width: 4rem;
  height: 4rem;
}

/* Grid Layout Adjustments */
@media (max-width: 768px) {
  .grid {
    grid-template-columns: 1fr; /* Single column for tablets and smaller screens */
    gap: 2rem; /* Adjust gap for better spacing */
  }

  .service-card {
    text-align: center;
  }

  h1 {
    font-size: 2rem; /* Reduce font size for titles on smaller screens */
  }

  p {
    font-size: 1rem; /* Adjust paragraph font size */
  }

  .icon {
    width: 3rem;
    height: 3rem; /* Smaller icon size for tablets */
  }
}

@media (max-width: 480px) {
  .grid {
    gap: 1.5rem; /* Further reduce gap for mobile screens */
  }

  h1 {
    font-size: 1.5rem; /* Smaller title font size for mobile */
  }

  p {
    font-size: 0.875rem; /* Smaller paragraph font size */
  }

  .icon {
    width: 2.5rem;
    height: 2.5rem; /* Smallest icon size for mobile screens */
  }

  .flex {
    flex-direction: column; /* Stack cards vertically on smaller screens */
    align-items: center;
    text-align: center;
  }

  .max-w-xs {
    width: 100%; /* Use full width for mobile screens */
  }
}
</style>

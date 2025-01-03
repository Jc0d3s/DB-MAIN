<script>
export default {
  name: "ServicesSection",
  data() {
    return {
      services: [
        { icon: "📊", title: "Business Consulting", description: "Solution for every business problem!" },
        { icon: "💡", title: "Market Research", description: "Know the market before taking steps." },
        { icon: "🎧", title: "Quality Services", description: "Unparalleled service from start to finish." },
      ],
    };
  },
};
</script>

<template>
  <section class="text-center py-10 bg-gray-50">
    <!-- Intro Section -->
    <div class="mb-10 px-4">
      <h1 class="text-3xl md:text-4xl font-bold text-gray-800">Welcome to the Elixir</h1>
      <p class="text-base md:text-lg text-gray-600 mt-4">
        Get expert consultancy and support with Elixir, an advisory firm<br class="hidden md:block">
        that stands by your side always.
      </p>
    </div>
    <!-- Services Section -->
    <div class="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-4 gap-8 px-4">
      <div class="service-card">
        <div class="icon bg-gray-200 w-16 h-16 mx-auto flex items-center justify-center rounded-full mb-4 text-2xl text-gray-800">
          📊
        </div>
        <h3 class="text-lg font-semibold text-gray-800">Business Consulting</h3>
        <p class="text-sm text-gray-600 mt-2">
          Solution for every business problem, readily and skillfully.
        </p>
      </div>
      <div class="service-card">
        <div class="icon bg-gray-200 w-16 h-16 mx-auto flex items-center justify-center rounded-full mb-4 text-2xl text-gray-800">
          ⏰
        </div>
        <h3 class="text-lg font-semibold text-gray-800">Risk Management</h3>
        <p class="text-sm text-gray-600 mt-2">
          Calculate every possible risk in your business, take control over them.
        </p>
      </div>
      <div class="service-card">
        <div class="icon bg-gray-200 w-16 h-16 mx-auto flex items-center justify-center rounded-full mb-4 text-2xl text-gray-800">
          💡
        </div>
        <h3 class="text-lg font-semibold text-gray-800">Market Research</h3>
        <p class="text-sm text-gray-600 mt-2">
          Know the market before taking steps, reduce risks before you go.
        </p>
      </div>
      <div class="service-card">
        <div class="icon bg-gray-200 w-16 h-16 mx-auto flex items-center justify-center rounded-full mb-4 text-2xl text-gray-800">
          🎧
        </div>
        <h3 class="text-lg font-semibold text-gray-800">Quality Services</h3>
        <p class="text-sm text-gray-600 mt-2">
          Experience unparalleled service, from beginning to completion.
        </p>
      </div>
    </div>
  </section>
  <div class="text-center my-6 px-4">
    <img 
      class="mx-auto rounded-lg shadow-lg max-w-full h-auto" 
      :src="'/assets/video-screenshot-2.jpg'" 
      :alt="imageAlt" 
    />
    <p v-if="caption" class="mt-4 text-gray-600 text-sm">{{ caption }}</p>
  </div>

  <div class="flex flex-col sm:flex-row justify-center space-y-6 sm:space-y-0 sm:space-x-8 my-8 px-4">
    <!-- Card 1 -->
    <div class="text-center max-w-xs">
      <div class="flex justify-center text-blue-900 text-3xl mb-4">
        <i class="fas fa-users"></i>
      </div>
      <h3 class="font-bold text-lg text-gray-800">Awesome Team</h3>
      <p class="mt-2 text-sm text-gray-600">
        Before talking destination, we shine a spotlight across your organization to fully understand it.
      </p>
    </div>
    <!-- Card 2 -->
    <div class="text-center max-w-xs">
      <div class="flex justify-center text-blue-900 text-3xl mb-4">
        <i class="fas fa-comments"></i>
      </div>
      <h3 class="font-bold text-lg text-gray-800">Excellent Support</h3>
      <p class="mt-2 text-sm text-gray-600">
        If you face any trouble, you can always let our dedicated support team help you. They are ready for you 24/7.
      </p>
    </div>
    <!-- Card 3 -->
    <div class="text-center max-w-xs">
      <div class="flex justify-center text-blue-900 text-3xl mb-4">
        <i class="fas fa-bolt"></i>
      </div>
      <h3 class="font-bold text-lg text-gray-800">Faster Performance</h3>
      <p class="mt-2 text-sm text-gray-600">
        We develop a systematic, well-ordered process of analysis, from concept through implementation.
      </p>
    </div>
  </div>
</template>



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
    width: 100%; /* Use full width for mobile screens! */
  }
}
</style>

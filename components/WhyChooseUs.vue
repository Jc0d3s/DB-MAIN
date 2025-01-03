<script>
export default {
  name: "WhyChooseUs",
  data() {
    return {
      reasons: [
        { icon: "💼", title: "We Are Professional", description: "We train and encourage marketplace leaders." },
        { icon: "🎨", title: "We Are Creative", description: "We create unique strategies tailored to your business." },
        { icon: "⏰", title: "24/7 Great Support", description: "Our team is always available to guide you." },
      ],
    };
  },
};
</script>


<template>
  <section class="bg-gray-50 py-12">
    <div class="container mx-auto px-6">
      <!-- Heading -->
      <h2 class="text-3xl font-bold text-center text-gray-900 mb-8">
        Why Choose Elixir
      </h2>
      <div class="border-t-4 border-blue-700 w-16 mx-auto mb-12"></div>

      <!-- Content -->
      <div class="flex flex-col md:flex-row md:space-x-8 ">
        <!-- Image Section -->
        <div class="flex-1 mb-8 md:mb-0">
          <img
            alt="Professional team"
            class="rounded-lg shadow-lg max-w-full h-auto mx-auto md:mx-0"
            src="\assets\why-choose-us.jpg"
          />
        </div>

        <!-- Text Section -->
        <div class="flex-1 space-y-8 md:space-y-20">
          <!-- Professional -->
          <div class="flex items-start space-x-4">
            <div class="text-blue-700">
              <i class="fas fa-comments text-3xl"></i>
            </div>
            <div>
              <h3 class="text-xl font-semibold text-gray-900">
                We Are Professional
              </h3>
              <p class="text-gray-600">
                We resource, train, mentor, and encourage marketplace leaders, business owners, and career professionals to excel in the workplace.
              </p>
            </div>
          </div>

          <!-- Creative -->
          <div class="flex items-start space-x-4">
            <div class="text-blue-700">
              <i class="fas fa-palette text-3xl"></i>
            </div>
            <div>
              <h3 class="text-xl font-semibold text-gray-900">
                We Are Creative
              </h3>
              <p class="text-gray-600">
                Our team designs innovative strategies, ensuring your business is characterized with forward-thinking solutions tailored to your needs.
              </p>
            </div>
          </div>

          <!-- 24/7 Support -->
          <div class="flex items-start space-x-4">
            <div class="text-blue-700">
              <i class="fas fa-clock text-3xl"></i>
            </div>
            <div>
              <h3 class="text-xl font-semibold text-gray-900">
                24/7 Great Support
              </h3>
              <p class="text-gray-600">
                Our team is always available to design marketing strategies, improve product positioning, and guide you to success.
              </p>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>

  <!-- Contact Us Section -->
  <div class="container mx-auto py-10 px-4">
    <div class="text-center bg-blue-800 text-white py-6 px-4 rounded-lg">
      <h2 class="text-xl font-bold">
        If you have any query related to investment... we are available 24/7
      </h2>
      <button class="mt-4 px-6 py-2 bg-white text-blue-800 font-semibold rounded hover:bg-blue-700 hover:text-white transition">
        Contact Us
      </button>
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
    width: 100%; /* Use full width for mobile screens */
  }
}
</style>

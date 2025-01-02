<template>
  <div class="mt-12">
    <h2 class="text-3xl font-bold text-center mb-10">Things You Get</h2>

    <!-- Features Section -->
    <section class="py-16 bg-gray-50">
      <div class="container mx-auto px-4">
        <div class="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3 gap-8">
          <!-- Card -->
          <div
            v-for="(item, index) in cards"
            :key="index"
            class="flex flex-col items-center text-center p-6 bg-white rounded-lg shadow"
          >
            <div class="mb-4">
              <img :src="item.icon" :alt="item.title" class="h-12 w-12" />
            </div>
            <h3 class="text-lg font-semibold text-gray-800">{{ item.title }}</h3>
            <p class="text-sm text-gray-600 mt-2">{{ item.description }}</p>
          </div>
        </div>
      </div>
    </section>

    <!-- Call-to-Action Section -->
    <div class="bg-blue-900 text-white min-h-screen flex items-center justify-center px-4">
      <div
        class="bg-blue-800 p-6 rounded-lg shadow-lg w-full max-w-4xl flex flex-col md:flex-row space-y-6 md:space-y-0"
      >
        <!-- Left Section -->
        <div
          class="md:w-1/2 p-6 border border-yellow-500 rounded-lg flex flex-col"
        >
          <h2 class="text-2xl font-bold mb-4">Request a call back</h2>
          <p class="text-gray-300">
            Would you like to speak to one of our financial advisers over the
            phone? Just submit your details, and we’ll be in touch shortly. You
            can also email us if you would prefer.
          </p>
        </div>
        <!-- Right Section -->
        <div class="md:w-1/2 bg-blue-700 p-6 rounded-lg">
          <h3 class="text-xl font-semibold mb-4">I would like to discuss:</h3>
          <form class="space-y-4">
            <div class="flex flex-col md:flex-row space-y-4 md:space-y-0 md:space-x-4">
              <input
                type="text"
                placeholder="Your Name"
                class="w-full md:w-1/2 p-3 rounded-lg bg-white text-gray-800"
              />
              <input
                type="text"
                placeholder="Phone Number"
                class="w-full md:w-1/2 p-3 rounded-lg bg-white text-gray-800"
              />
            </div>
            <input
              type="text"
              placeholder="Subject"
              class="w-full p-3 rounded-lg bg-white text-gray-800"
            />
            <button
              type="submit"
              class="w-full bg-yellow-500 text-blue-900 font-bold py-3 rounded-lg hover:bg-yellow-400 transition"
            >
              Submit
            </button>
          </form>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "CallToAction",
  data() {
    return {
      cards: [
        {
          icon: "/assets/wand-magic-sparkles-solid.svg",
          title: "Creative Support",
          description:
            "We transform brands, grow businesses, and tell brand and product stories in the most creative way.",
        },
        {
          icon: "/assets/cloud-arrow-up-solid.svg",
          title: "Creating Experiences",
          description:
            "We cover a large range of creative platforms and digital projects with one purpose: to create experiences.",
        },
        {
          icon: "/assets/bullseye-solid.svg",
          title: "Product Consulting",
          description:
            "We guide you through the pipelines that generate new products with higher potential and lower risk.",
        },
        {
          icon: "/assets/globe-solid.svg",
          title: "Business Boosting",
          description:
            "We provide energy-efficient and environmentally conservative solutions to our clients to boost their business.",
        },
        {
          icon: "/assets/money-bill-solid.svg",
          title: "Strategic Approach",
          description:
            "Based on a solid strategic framework and real, relevant research, we create prototypes, not presentations.",
        },
        {
          icon: "/assets/chart-simple-solid.svg",
          title: "Logistic Consulting",
          description:
            "We work buy side and sell side to give our clients hard-hitting answers and focus hard on best opportunities.",
        },
      ],
    };
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

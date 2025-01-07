<template>
  <section class="text-center py-10 bg-gray-50">
    <!-- Intro Section -->
    <div class="intro mb-10">
      <h1 class="text-4xl font-bold text-gray-800">Welcome to the Elixir</h1>
      <p class="text-lg text-gray-600 mt-4">
        Get expert consultancy and support with Elixir, an advisory firm <br />
        that stands by your side always.
      </p>
    </div>
    <!-- Services Section -->
    <div class="service-cards grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4">
      <div class="service-card">
        <div class="icon bg-gray-200 w-16 h-16 mx-auto flex items-center justify-center rounded-full mb-4 text-2xl text-gray-800">
          📊
        </div>
        <h3 class="text-xl font-semibold text-gray-800">Business Consulting</h3>
        <p class="text-gray-600 mt-2">
          Solution for every business<br />related problem, readily<br /> and skillfully.
        </p>
      </div>
      <div class="service-card">
        <div class="icon bg-gray-200 w-16 h-16 mx-auto flex items-center justify-center rounded-full mb-4 text-2xl text-gray-800">
          ⏰
        </div>
        <h3 class="text-xl font-semibold text-gray-800">Risk Management</h3>
        <p class="text-gray-600 mt-2">
          Calculate every possible risk<br /> in your business, take<br /> control over them.
        </p>
      </div>
      <div class="service-card">
        <div class="icon bg-gray-200 w-16 h-16 mx-auto flex items-center justify-center rounded-full mb-4 text-2xl text-gray-800">
          💡
        </div>
        <h3 class="text-xl font-semibold text-gray-800">Market Research</h3>
        <p class="text-gray-600 mt-2">
          Know the market before<br />taking any step, reduce<br /> risks before you go.
        </p>
      </div>
      <div class="service-card">
        <div class="icon bg-gray-200 w-16 h-16 mx-auto flex items-center justify-center rounded-full mb-4 text-2xl text-gray-800">
          🎧
        </div>
        <h3 class="text-xl font-semibold text-gray-800">Quality Services</h3>
        <p class="text-gray-600 mt-2">
          Experience unparalleled <br />service, from beginning<br /> to final construction.
        </p>
      </div>
    </div>
  </section>
  <div class="image-section text-center my-6">
    <img 
      :src="'/assets/video-screenshot-2.jpg'" 
      :alt="imageAlt" 
      class="animated-image mx-auto rounded-lg shadow-lg max-w-[1000px] h-auto" 
    />
    <p v-if="caption" class="mt-4 text-gray-600 text-sm">{{ caption }}</p>
  </div>

  <div class="additional-cards flex justify-center space-x-8 my-8">
    <!-- Card 1 -->
    <div class="text-center max-w-xs">
      <div class="flex justify-center text-blue-900 text-4xl mb-4">
        <i class="fas fa-users"></i>
      </div>
      <h3 class="font-bold text-lg text-gray-800">Awesome Team</h3>
      <p class="mt-2 text-gray-600">
        Before talking destination, we shine a spotlight across your organization to fully understand it.
      </p>
    </div>

    <!-- Card 2 -->
    <div class="text-center max-w-xs">
      <div class="flex justify-center text-blue-900 text-4xl mb-4">
        <i class="fas fa-comments"></i>
      </div>
      <h3 class="font-bold text-lg text-gray-800">Excellent Support</h3>
      <p class="mt-2 text-gray-600">
        If you face any trouble, you can always let our dedicated support team help you. They are ready for you 24/7.
      </p>
    </div>

    <!-- Card 3 -->
    <div class="text-center max-w-xs">
      <div class="flex justify-center text-blue-900 text-4xl mb-4">
        <i class="fas fa-bolt"></i>
      </div>
      <h3 class="font-bold text-lg text-gray-800">Faster Performance</h3>
      <p class="mt-2 text-gray-600">
        We develop a systematic, well-ordered process of analysis, from concept through implementation.
      </p>
    </div>
  </div>
  <section class="services-section bg-gray-50 py-12">
    <div class="container mx-auto px-4">
      <!-- Our Services Title -->
      <div class="text-center mb-4">
        <h2 class="text-3xl font-bold text-gray-800 mb-8">
          Our Services
        </h2>
        <hr class="w-24 h-1 mx-auto border-blue-600 bg-blue-600 rounded mb-12" />
      </div>

      <!-- Business Consulting Section -->
      <div class="flex flex-wrap items-center justify-center lg:justify-between mb-4">
        <!-- Image -->
        <div class="w-full lg:w-1/2 px-4 mb-4 lg:mb-0">
          <img
            src="C:\Users\LENOVO\Documents\JeevanTask1\JeevanTask1\public\assets\6.jpg"
            alt="Business Consulting"
            class="animated-image rounded-lg shadow-lg w-full"
          />
        </div>
        <!-- Text Content -->
        <div class="w-full lg:w-1/2 px-4">
          <h3 class="text-2xl font-bold text-gray-800 mb-4">
            Business Consulting
          </h3>
          <p class="text-gray-600 leading-relaxed mb-6">
            As one of the world’s largest accountancy networks, elixir helps a diverse range of clients with a diverse range of needs. This is especially true of our Advisory Practice, which provides corporate finance and transaction services, business restructuring.
          </p>
          <a
            href="#"
            class="text-blue-600 font-semibold hover:underline flex items-center"
          >
            Learn More
            <span class="ml-2">→</span>
          </a>
        </div>
      </div>

      <!-- Tax Consulting Section -->
      <div class="flex flex-wrap items-center justify-center lg:justify-between flex-row-reverse mb-4">
        <!-- Image -->
        <div class="w-full lg:w-1/2 px-4 mb-4 lg:mb-0">
          <img
            src="C:\Users\LENOVO\Documents\JeevanTask1\JeevanTask1\public\assets\7.jpg"
            alt="Tax Consulting"
            class="animated-image rounded-lg shadow-lg w-full"
          />
        </div>
        <!-- Text Content -->
        <div class="w-full lg:w-1/2 px-4">
          <h3 class="text-2xl font-bold text-gray-800 mb-4">
            Tax Consulting
          </h3>
          <p class="text-gray-600 leading-relaxed mb-6">
            Elixir serves clients across the country and around the world as they navigate an increasingly complex tax landscape. Our tax professionals draw on deep experience and industry-specific knowledge to deliver clients the insights and innovation they need.
          </p>
          <a
            href="#"
            class="text-blue-600 font-semibold hover:underline flex items-center"
          >
            Learn More
            <span class="ml-2">→</span>
          </a>
        </div>
      </div>

      <!-- Technology Consulting Section -->
      <div class="flex flex-wrap items-center justify-center lg:justify-between mb-4">
        <!-- Image -->
        <div class="w-full lg:w-1/2 px-4 mb-4 lg:mb-0">
          <img
            src="C:\Users\LENOVO\Documents\JeevanTask1\JeevanTask1\public\assets\8.jpg"
            alt="Technology Consulting"
            class="animated-image rounded-lg shadow-lg w-full"
          />
        </div>
        <!-- Text Content -->
        <div class="w-full lg:w-1/2 px-4">
          <h3 class="text-2xl font-bold text-gray-800 mb-4">
            Advisory
          </h3>
          <p class="text-gray-600 leading-relaxed mb-6">
            To help you understand what this road looks like, we surveyed 1165 digital marketers across Europe and North America to explore current trends and priorities in digital marketing.
          </p>
          <a
            href="#"
            class="text-blue-600 font-semibold hover:underline flex items-center"
          >
            Learn More
            <span class="ml-2">→</span>
          </a>
        </div>
      </div>
    </div>
  </section>
  <div class="flex flex-col md:flex-row justify-evenly items-center bg-gray-50 p-8 space-y-6 md:space-y-0 md:space-x-4">
    <div class="flex items-start space-x-4">
      <div class="text-blue-700">
        <i class="fas fa-credit-card text-2xl"></i>
      </div>
      <div>
        <h3 class="text-lg font-semibold text-gray-900">Special financing</h3>
        <p class="text-gray-600">Apply for special financial support and <br />earn exclusive rewards.</p>
      </div>
    </div>
    <div class="flex items-start space-x-2">
      <div class="text-blue-700">
        <i class="fas fa-comments text-2xl"></i>
      </div>
      <div>
        <h3 class="text-lg font-semibold text-gray-900">Chat with team</h3>
        <p class="text-gray-600">
          Have a question? Chat online with an<br /> expert.
          <a href="#" class="text-blue-600 underline">Start chatting</a>
        </p>
      </div>
    </div>
    <div class="flex items-start space-x-2">
      <div class="text-blue-700">
        <i class="fas fa-phone text-2xl"></i>
      </div>
      <div>
        <h3 class="text-lg font-semibold text-gray-900">Call a specialist</h3>
        <p class="text-gray-600">
          Our 24/7 support team is ready for <br />you at 1-800-MY-Elixir.
        </p>
      </div>
    </div>
  </div>
</template>

<script>
import { nextTick } from "vue";
import { gsap } from "gsap";

export default {
  name: "ServicesSection",
  mounted() {
    nextTick(() => {
      const animateSection = (entries, observer) => {
        entries.forEach((entry) => {
          if (entry.isIntersecting) {
            const target = entry.target;

            gsap.from(target, {
              opacity: 0,
              y: 50,
              duration: 1,
              ease: "power3.out",
            });

            observer.unobserve(target);
          }
        });
      };

      const observerOptions = {
        threshold: 0.2,
      };

      const observer = new IntersectionObserver(animateSection, observerOptions);

      document.querySelectorAll(".intro, .service-card, .animated-image, .flex, .services-section h2, .services-section img, .services-section p, .services-section a").forEach((section) => {
        observer.observe(section);
      });
    });
  },
};
</script>

<style scoped>
.icon {
  width: 4rem;
  height: 4rem;
}
/* Grid Layout Adjustments */
@media (max-width: 768px) {
  .grid {
    grid-template-columns: 1fr;
    gap: 2rem;
  }

  .service-card {
    text-align: center;
  }

  h1 {
    font-size: 2rem;
  }

  p {
    font-size: 1rem;
  }

  .icon {
    width: 3rem;
    height: 3rem;
  }
}
@media (max-width: 480px) {
  .grid {
    gap: 1.5rem;
  }

  h1 {
    font-size: 1.5rem;
  }

  p {
    font-size: 0.875rem;
  }

  .icon {
    width: 2.5rem;
    height: 2.5rem;
  }

  .flex {
    flex-direction: column;
    align-items: center;
    text-align: center;
  }

  .max-w-xs {
    width: 100%;
  }
}
</style>

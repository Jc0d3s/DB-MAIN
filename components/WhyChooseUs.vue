<template>
  <section class="bg-gray-50 py-12">
    <div class="container mx-auto px-6">
      <!-- Heading -->
      <h2 class="text-3xl font-bold text-center text-gray-900 mb-8">
  Why Choose Elixir
</h2>

      <div class="border-t-4 border-blue-700 w-16 mx-auto mb-12 animate-heading"></div>

      <!-- Content -->
      <div class="flex flex-col md:flex-row md:space-x-8">
        <!-- Image Section -->
        <div class="flex-1 mb-8 md:mb-0 animate-image">
          <img
            alt="Professional team"
            class="rounded-lg shadow-lg max-w-full h-auto mx-auto md:mx-0"
            src="/assets/why-choose-us.jpg"
          />
        </div>

        <!-- Text Section -->
        <div class="flex-1 space-y-8 md:space-y-20">
          <!-- Professional -->
          <div class="flex items-start space-x-4 animate-item">
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
          <div class="flex items-start space-x-4 animate-item">
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
          <div class="flex items-start space-x-4 animate-item">
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
    <div class="text-center bg-blue-800 text-white py-6 px-4 rounded-lg animate-contact">
      <h2 class="text-xl font-bold">
        If you have any query related to investment... we are available 24/7
      </h2>
      <button class="mt-4 px-6 py-2 bg-white text-blue-800 font-semibold rounded hover:bg-blue-700 hover:text-white transition">
        Contact Us
      </button>
    </div>
  </div>
</template>

<script>
import { nextTick } from "vue";
import { gsap } from "gsap";

export default {
  name: "WhyChooseUs",
  mounted() {
    nextTick(() => {
      const animateSection = (entries, observer) => {
        entries.forEach((entry) => {
          if (entry.isIntersecting) {
            const target = entry.target;

            // Trigger GSAP animations
            if (target.classList.contains("animate-heading")) {
              gsap.from(target, { opacity: 0, y: -20, duration: 1, ease: "power3.out",onComplete: () => {
                target.style.opacity = "2";
              }});
            }

            if (target.classList.contains("animate-image")) {
              gsap.from(target, { opacity: 0, scale: 0.8, duration: 1, ease: "power3.out" });
            }

            if (target.classList.contains("animate-item")) {
              gsap.from(target, { opacity: 0, x: -20, duration: 0.8, ease: "power3.out", stagger: 0.3 });
            }

            if (target.classList.contains("animate-contact")) {
              gsap.from(target, { opacity: 0, y: 20, duration: 1, ease: "power3.out" });
            }

            observer.unobserve(target);
          }
        });
      };

      const observerOptions = {
        threshold: 0.2,
      };

      const observer = new IntersectionObserver(animateSection, observerOptions);

      document.querySelectorAll(".animate-heading").forEach((el) => observer.observe(el));
      document.querySelectorAll(".animate-image").forEach((el) => observer.observe(el));
      document.querySelectorAll(".animate-item").forEach((el) => observer.observe(el));
      document.querySelectorAll(".animate-contact").forEach((el) => observer.observe(el));
    });
  },
};
</script>

<style scoped>
/* General Styles */
.icon {
  width: 4rem;
  height: 4rem;
}
.text-gray-600 {
  color: #4b5563; /* Ensure a solid color, not rgba with transparency */
  opacity: 1; /* Set full opacity */
}


/* Responsive Adjustments */
@media (max-width: 768px) {
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
}
</style>

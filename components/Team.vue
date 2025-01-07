<template>
  <div class="container mx-auto px-4 py-12">
    <h1 class="text-4xl font-bold text-center mb-12 animate-heading text-gray-900">
      Global Leadership
    </h1>
    <div class="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 gap-8">
      <div
        v-for="member in team"
        :key="member.name"
        class="text-center bg-white p-6 rounded-lg shadow-md animate-card"
      >
        <img
          :src="member.image"
          alt="Team Member"
          class="w-full h-48 object-cover rounded-lg mb-4"
        />
        <h2 class="text-2xl font-bold mt-4">{{ member.name }}</h2>
        <p class="text-gray-500">{{ member.role }}</p>
        <p class="mt-4 text-gray-700">{{ member.description }}</p>
      </div>
    </div>
  </div>
</template>

<script>
import { nextTick } from "vue";
import { gsap } from "gsap";

export default {
  name: "Team",
  data() {
    return {
      team: [
        {
          name: "Reenal Scott",
          role: "Advertising Consultant",
          description: "Founder and CEO of Elixir since 2013.",
          image: "/assets/portrait-1.jpg",
        },
        {
          name: "Lily Anderson",
          role: "Activation Consultant",
          description: "Leads Elixir UK operations.",
          image: "/assets/portrait-6.jpg",
        },
        {
          name: "Thomas Anderson",
          role: "Change Management Consultant",
          description: "Focuses on talent retention.",
          image: "/assets/portrait-3.jpg",
        },
        {
          name: "Legartha Mantana",
          role: "Brand Management Consultant",
          description:
            "As General Counsel of Elixir, Tony oversees global legal activities and policies across all aspects.",
          image: "/assets/portrait-4.jpg",
        },
        {
          name: "John Snow",
          role: "Business Analyst",
          description:
            "John has overseen the meteoric growth while protecting scaling its uniquely creative and culture.",
          image: "/assets/portrait-5.jpg",
        },
        {
          name: "Ragner Lothbrok",
          role: "Business Consultant",
          description:
            "Ragner, SVP of Engineering, oversees Elixir’s vast engineering organization which drives the core programming.",
          image: "/assets/portrait-7.jpg",
        },
      ],
    };
  },
  mounted() {
    nextTick(() => {
      const animateSection = (entries, observer) => {
        entries.forEach((entry) => {
          if (entry.isIntersecting) {
            const target = entry.target;

            if (target.classList.contains("animate-heading")) {
              gsap.from(target, { opacity: 0, y: -30, duration: 1, ease: "power3.out",onComplete: () => {
                target.style.opacity = "1";
              }});
            }

            if (target.classList.contains("animate-card")) {
              gsap.from(target, {
                opacity: 0,
                y: 30,
                duration: 1,
                ease: "power3.out",
                stagger: 0.2,
              });
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
      document.querySelectorAll(".animate-card").forEach((el) => observer.observe(el));
    });
  },
};
</script>

<style scoped>

.text-gray-600 {
  color: #4b5563; /* Ensure a solid color, not rgba with transparency */
  opacity: 1; /* Set full opacity */
}

/* Responsive Adjustments */
@media (max-width: 768px) {
  .grid {
    grid-template-columns: 1fr;
    gap: 2rem;
  }
}

@media (max-width: 480px) {
  h1 {
    font-size: 1.5rem;
  }
}
</style>

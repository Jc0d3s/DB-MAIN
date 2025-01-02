<template>
  <div class="container mx-auto px-4 py-12">
    <h1 class="text-4xl font-bold text-center mb-12">Global Leadership</h1>
    <div class="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 gap-8">
      <div
        v-for="member in team"
        :key="member.name"
        class="text-center bg-white p-6 rounded-lg shadow-md"
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

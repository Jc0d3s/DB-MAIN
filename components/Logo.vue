<script>
export default {
  data() {
    return {
      logos: [
        { name: "Partnerco", src: "/assets/logo1.png" },
        { name: "TVC Marketing", src: "/assets/logo2.png" },
        { name: "Arcade", src: "/assets/logo3.png" },
        { name: "Bearbrand", src: "/assets/logo4.png" },
        { name: "Haircuts & Beards", src: "/assets/logo5.png" },
        { name: "Vice", src: "/assets/logo6.png" },
      ],
    };
  },
};
</script>


<template>
  <section class="bg-gray-100 py-8 sm:py-16">
    <div
      class="container mx-auto grid grid-cols-2 sm:grid-cols-3 md:grid-cols-4 lg:grid-cols-6 gap-6 items-center"
    >
      <div
        v-for="logo in logos"
        :key="logo.name"
        class="flex justify-center p-4 bg-white shadow rounded-lg"
      >
        <img :src="logo.src" :alt="logo.name" class="h-16 sm:h-20 md:h-24 object-contain" />
      </div>
    </div>
  </section>
</template>



<style scoped>
/* Optional custom styling */
</style>

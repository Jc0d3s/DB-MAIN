<script>
export default {
  name: "NewsSection",
  data() {
    return {
      newsItems: [
        {
          image: "/assets/9.jpg",
          title: "Tax impacts of lease mean accounting change",
          author: "Paul O'Sullivan",
          description:
            "HMRC released a consultation document to flag some potential tax impacts that a forthcoming change...",
          link: "#",
        },
        {
          image: "/assets/10.jpg",
          title: "What Brexit means for data protection law",
          author: "Enrico Ambrosi",
          description:
            "Assuming that the referendum is not ignored completely, there are two possible futures for the UK...",
          link: "#",
        },
        {
          image: "/assets/14.jpg",
          title: "The growing menace of social engineering fraud",
          author: "Robson",
          description:
            "Social engineering involves the collection of information from various sources about a target...",
          link: "#",
        },
      ],
    };
  },
};
</script>


<template>
  <div class="bg-gray-100 py-8 sm:py-10">
    <div class="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8">
      <h2 class="text-2xl sm:text-3xl font-bold text-center text-gray-800 mb-6 sm:mb-8">
        Latest News
      </h2>
      <div class="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3 gap-6">
        <div
          v-for="(news, index) in newsItems"
          :key="index"
          class="bg-white rounded-lg shadow-lg overflow-hidden flex flex-col"
        >
          <img
            :src="news.image"
            :alt="news.title"
            class="w-full h-40 sm:h-48 object-cover"
          />
          <div class="p-4 sm:p-6 flex flex-col flex-grow">
            <h3 class="text-lg sm:text-xl font-semibold text-gray-800">
              {{ news.title }}
            </h3>
            <p class="text-xs sm:text-sm text-gray-500 mb-2 sm:mb-4">
              By {{ news.author }}
            </p>
            <p class="text-gray-600 text-sm sm:text-base mb-4 flex-grow">
              {{ news.description }}
            </p>
            <a
              :href="news.link"
              class="text-blue-600 hover:underline font-semibold flex items-center mt-auto"
            >
              Learn More <span class="ml-2">&rarr;</span>
            </a>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>



<style scoped>
/* Optional custom styling */
</style>

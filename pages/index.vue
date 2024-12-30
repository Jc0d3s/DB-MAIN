<template>
  <div>
    <!-- Contact Info Bar -->
    <div class="bg-[#2B3B5C] text-white text-sm py-4">
      <div class="container mx-auto flex justify-between items-center px-4">
        <div class="flex space-x-16 ml-16 -mr-16">
          <span>
            <i class="fas fa-map-marker-alt mr-2 text-[#fdd428]"></i>
            1010 Avenue, New York, NY 10018 US.
          </span>
          <span>
            <i class="fa fa-phone-alt mr-2 text-[#fdd428] transform rotate-90"></i>
            212 386 5575, 212 386 5576
          </span>
        </div>
        <span class="relative left-[-40px]">
          <i class="far fa-clock mr-2 text-[#fdd428]"></i>
          Mon-Sat, 8.00-18.00. Sunday CLOSED
        </span>
      </div>
    </div>

    <!-- Navigation Bar -->
    <nav class="bg-white bg-opacity-50 shadow-md sticky top-0  z-50 backdrop-blur-sm ml-0 w-full">
      <div class="container mx-auto px-4">
        <div class="flex items-center">
          <!-- Logo -->
          <div class="py-4 mr-4 ml-12">
            <img src="/assets/logo-dark.png" alt="Elixir" class="h-8">
          </div>

          <!-- Navigation Links -->
          <div class="hidden lg:flex items-center gap-8 ml-4">
            <!-- Home Dropdown -->
            <div class="group relative ml-8">
  <button class="py-4 flex items-center">
    <a href="#" class="navbar-collapse hover:text-[#1f1f1f] font-montserrat text-[16px] font-semibold">Home</a>
    <i class="fas fa-chevron-down ml-1"></i>
  </button>
  <div class="hidden group-hover:flex flex-col absolute z-50 bg-white shadow-lg">
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Slider Header</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Slider Classic</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Static Header</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Static Classic</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Youtube Background</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Youtube Classic</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Self-hosted Video</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Self-hosted Classic</a>
  </div>


            </div>

            <!-- Pages Dropdown -->
           <!-- Pages Dropdown -->
<div class="group relative">
  <button class="py-4 flex items-center">
    <a href="JavaScript:void(0)" class="navbar-collapse hover:text-[#1f1f1f] font-montserrat text-[16px] font-semibold">Pages</a>
    <i class="fas fa-chevron-down ml-1"></i>
  </button>
  <div class="hidden group-hover:flex flex-col absolute z-50 bg-white shadow-lg">
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Services</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">About</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Alumni</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Blank Page</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">404 Page</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Login</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Registration</a>
  </div>
</div>

<!-- News Dropdown -->
<div class="group relative">
  <button class="py-4 flex items-center">
    <a href="JavaScript:void(0)" class="navbar-collapse hover:text-[#1f1f1f] font-montserrat text-[16px] font-semibold">News</a>
    <i class="fas fa-chevron-down ml-1"></i>
  </button>
  <div class="hidden group-hover:flex flex-col absolute z-50 bg-white shadow-lg">
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Newsroom</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Single News</a>
  </div>
</div>

<!-- Elements Dropdown -->
<div class="group relative">
  <button class="py-4 flex items-center">
    <a href="JavaScript:void(0)" class="navbar-collapse hover:text-[#1f1f1f] font-montserrat text-[16px] font-semibold">Elements</a>
    <i class="fas fa-chevron-down ml-1"></i>
  </button>
  <div class="hidden group-hover:flex flex-col absolute z-50 bg-white shadow-lg">
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Buttons</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Colors</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Google Map</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Grid</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Icons</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Layout Helpers</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Modal Video</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Owl Carousal</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Slider</a>
    <a href="#" class="px-4 py-2 text-[12px] font-semibold hover:bg-gray-100 whitespace-nowrap">Typography</a>
  </div>
</div>


            <!-- Contact Link -->
            <a href="#" class="py-4 font-montserrat-16px text-[16px] font-semibold">Contact</a>
          </div>

          <!-- Purchase Button -->
          <button class="border-2 border-[#2B3B5C] text-[#2B3B5C] px-4 py-1 rounded-full hover:bg-[#2B3B5C] hover:text-white transition-colors absolute right-14  font-montserrat-16px text-[16px] font-semibold">
            Purchase
          </button>
        </div>
      </div>
    </nav>



    <!-- Header Section -->
    <div class="relative">
      <!-- Dynamic Background Image -->
      <img :src="headers[currentHeader].image" alt="Header Image" class="w-full h-screen object-cover -mt-16 transition-all duration-500">

      <!-- Header Content -->
      <div class="absolute inset-0 flex items-start justify-start text-black p-8 mt-24 ml-16">
        <div>
 <!-- Title -->
 <transition name="pop-up">
      <h1
        v-if="headers[currentHeader]"
        class="text-[#2A3855] text-[67.34px] font-bold mb-2"
        style="font-family: 'Montserrat', sans-serif;"
      >
        {{ headers[currentHeader].title }}
      </h1>
    </transition>

<!-- Description -->
<p
      class="text-[#2A3855] text-[28.43px] mb-12 animate-pop-up"
      :class="{ 'animate-pop-up': showAnimation }"
      style="font-family: 'Open Sans', sans-serif;"
      v-html="headers[currentHeader].description"
    ></p>


          <!-- Buttons -->
          <div>
            <a href="#" class="bg-[#00274D] text-white font-semibold px-8 py-3 rounded-lg shadow-md hover:bg-[#001F3A] transition duration-200 mr-3">
              {{ headers[currentHeader].button1.text }}
            </a>
            <a :href="headers[currentHeader].button2.link" class="bg-[#ffc107] text-[#212529] font-semibold px-8 py-3 rounded-lg shadow-md hover:bg-[#e0a800] transition duration-200">
              {{ headers[currentHeader].button2.text }}
            </a>
          </div>
        </div>
      </div>

      <!-- Navigation Buttons -->
      <div class="absolute top-1/2 left-4 transform -translate-y-1/2 bg-none bg-opacity-50 text-black w-10 h-10 rounded-full flex items-center justify-center opacity-80 hover:opacity-100 transition" @click="previousHeader">
        <i class="fas fa-chevron-left font-fontawesome-12px content-/f105"></i>
      </div>
      <div class="absolute top-1/2 right-4 transform -translate-y-1/2 bg-none bg-opacity-50 text-black w-10 h-10 rounded-full flex items-center justify-center opacity-80 hover:opacity-100 transition" @click="nextHeader">
        <i class="fas fa-chevron-right font-fontawesome-12px content-/f105"></i>
      </div>
    </div>
  </div>

  <section class="text-center py-10 bg-gray-50">
    <!-- Intro Section -->
    <div class="mb-10">
      <h1 class="text-4xl font-bold text-gray-800">Welcome to the Elixir</h1>
      <p class="text-lg text-gray-600 mt-4">
        Get expert consultancy and support with Elixir, an advisory firm <br> that stands by your side always.
      </p>
    </div>
    <!-- Services Section -->
    <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4">
      <div class="service-card">
        <div class="icon bg-gray-200 w-16 h-16 mx-auto flex items-center justify-center rounded-full mb-4 text-2xl text-gray-800">
          📊
        </div>
        <h3 class="text-xl font-semibold text-gray-800">Business Consulting</h3>
        <p class="text-gray-600 mt-2">
          Solution for every business<br>related problem, readily<br> and skillfully.
        </p>
      </div>
      <div class="service-card">
        <div class="icon bg-gray-200 w-16 h-16 mx-auto flex items-center justify-center rounded-full mb-4 text-2xl text-gray-800">
          ⏰
        </div>
        <h3 class="text-xl font-semibold text-gray-800">Risk Management</h3>
        <p class="text-gray-600 mt-2">
          Calculate every possible risk<br> in your business, take<br> control over them.
        </p>
      </div>
      <div class="service-card">
        <div class="icon bg-gray-200 w-16 h-16 mx-auto flex items-center justify-center rounded-full mb-4 text-2xl text-gray-800">
          💡
        </div>
        <h3 class="text-xl font-semibold text-gray-800">Market Research</h3>
        <p class="text-gray-600 mt-2">
          Know the market before<br>taking any step, reduce<br> risks before you go.
        </p>
      </div>
      <div class="service-card">
        <div class="icon bg-gray-200 w-16 h-16 mx-auto flex items-center justify-center rounded-full mb-4 text-2xl text-gray-800">
          🎧
        </div>
        <h3 class="text-xl font-semibold text-gray-800">Quality Services</h3>
        <p class="text-gray-600 mt-2">
          Experience unparalleled <br>service, from beginning<br> to final construction.
        </p>
      </div>
    </div>
  </section>
  <div class="text-center my-6">
  <img 
    :src="'/assets/video-screenshot-2.jpg'" 
    :alt="imageAlt" 
    class="mx-auto rounded-lg shadow-lg max-w-[1000px] h-auto" 
  />
  <p v-if="caption" class="mt-4 text-gray-600 text-sm">{{ caption }}</p>
</div>

<div class="flex justify-center space-x-8 my-8">
    <!-- Card 1 -->
    <div class="text-center max-w-xs">
      <div class="flex justify-center text-blue-900 text-4xl mb-4">
        <i class="fas fa-users"></i> <!-- Replace with your preferred icon -->
      </div>
      <h3 class="font-bold text-lg text-gray-800">Awesome Team</h3>
      <p class="mt-2 text-gray-600">
        Before talking destination, we shine a spotlight across your organization to fully understand it.
      </p>
    </div>

    <!-- Card 2 -->
    <div class="text-center max-w-xs">
      <div class="flex justify-center text-blue-900 text-4xl mb-4">
        <i class="fas fa-comments"></i> <!-- Replace with your preferred icon -->
      </div>
      <h3 class="font-bold text-lg text-gray-800">Excellent Support</h3>
      <p class="mt-2 text-gray-600">
        If you face any trouble, you can always let our dedicated support team help you. They are ready for you 24/7.
      </p>
    </div>

    <!-- Card 3 -->
    <div class="text-center max-w-xs">
      <div class="flex justify-center text-blue-900 text-4xl mb-4">
        <i class="fas fa-bolt"></i> <!-- Replace with your preferred icon -->
      </div>
      <h3 class="font-bold text-lg text-gray-800">Faster Performance</h3>
      <p class="mt-2 text-gray-600">
        We develop a systematic, well-ordered process of analysis, from concept through implementation.
      </p>
    </div>
  </div>
  <section class="bg-gray-50 py-12">
  <div class="container mx-auto px-4">
    <!-- About Us Section (Previous Content) -->



    <!-- Our Services Title -->
    <div class="text-center mb-4">
      <h2 class="text-3xl font-bold text-gray-800 mb-8">
        Our Services!
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
          class="rounded-lg shadow-lg w-full"
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
          class="rounded-lg shadow-lg w-full"
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
          class="rounded-lg shadow-lg w-full"
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
      <p class="text-gray-600">Apply for special financial support and <br>earn exclusive rewards.</p>
    </div>
  </div>
  <div class="flex items-start space-x-2">
    <div class="text-blue-700">
      <i class="fas fa-comments text-2xl"></i>
    </div>
    <div>
      <h3 class="text-lg font-semibold text-gray-900">Chat with team</h3>
      <p class="text-gray-600">
        Have a question? Chat online with an<br> expert.
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
        Our 24/7 support team is ready for <br>you at 1-800-MY-Elixir.
      </p>
    </div>
  </div>
</div>
<section class="bg-gray-50 py-12">
    <div class="container mx-auto px-6">
      <!-- Heading -->
      <h2 class="text-3xl font-bold text-center text-gray-900 mb-8">
        Why Choose Elixir
      </h2>
      <div class="border-t-4 border-blue-700 w-16 mx-auto mb-12"></div>

      <!-- Content -->
      <div class="flex flex-col md:flex-row md:space-x-8">
        <!-- Image Section -->
        <div class="flex-1 mb-8 md:mb-0 ml-12">
          <img
            src="C:\Users\LENOVO\Documents\JeevanTask1\JeevanTask1\public\assets\why-choose-us.jpg"
            alt="Professional team"
            class="rounded-lg shadow-lg"
          />
        </div>

        <!-- Text Section -->
        <div class="flex-1 space-y-24">
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
                We resource, train, speak, mentor and encourage; <br>marketplace
                leaders, business owners, and career<br> professionals to be
                effective in the workplace.
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
                With so many factors to consider when deciding how to<br>
                characterize your company, wouldn't it be great to have a<br> group
                of forward-thinking, well-informed individuals on<br> board who
                know what they're doing?
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
                Design clever and compelling marketing strategies,<br> improve
                product positioning, and drive conversion rates. <br>Elixir is
                always available to guide you.
              </p>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <div class="bg-blue-900 text-white flex flex-col items-center justify-center py-2 px-2 rounded-lg shadow-md">
    <p class="text-2xl font-bold text-center mb-4">
      If you have any query related investment... we are available 24/7
    </p>
    <button
      class="bg-white text-blue-900 font-medium py-3 px-6 rounded-full shadow hover:bg-gray-100 transition text-lg"
    >
      Contact Us
    </button>
  </div>

</template>

<script>
export default {
  name: "ImageSection",
  data() {
    return {
      currentHeader: 0, // Index of the current header
      showAnimation: true, // Control the animation trigger
      headers: [
        {
          image: '/assets/header-5.jpg', // Correct path for your project
          title: 'Expert Consultants',
          description: 'Over 10 years of experience in helping clients<br>find comprehensive solutions.',
          button1: { text: 'Read More', link: '#' },
          button2: { text: 'Contact Us', link: 'contact.html' },
          textClass: 'text-black',
        },
        {
          image: '/assets/header-1.jpg', // Correct path for your project
          title: 'Growth Partners',
          description: 'Connect with top consultants hand-picked by<br> Elixir consulting and finance.',
          button1: { text: 'Our Services', link: 'services.html' },
          button2: { text: 'Get Started', link: 'start.html' },
          textClass: 'text-black',
        },
        {
          image: '/assets/header-6.jpg', // Correct path for your project
          title: 'Helping Leaders',
          description: 'We look forward to help you in taking your <br>company to new height.',
          button1: { text: 'Learn More', link: '#' },
          button2: { text: 'Join Us', link: 'join.html' },
          textClass: 'text-black',
        },
      ],
    };
  },
  methods: {
    nextHeader() {
      this.currentHeader = (this.currentHeader + 1) % this.headers.length;
      this.triggerPopUp();
    },
    previousHeader() {
      this.currentHeader =
        (this.currentHeader - 1 + this.headers.length) % this.headers.length;
      this.triggerPopUp();
    },
    triggerPopUp() {
      this.showAnimation = false; // Disable animation
      this.$nextTick(() => {
        this.showAnimation = true; // Enable animation after DOM update
      });
    },
  
},name: "FeatureSection",
name: "OurServices",
name: "SupportOptions",
name: "WhyChooseElixir",
name: "InvestmentBanner",
};

</script>


<style scoped>

@import "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css";
@import "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css";

</style>


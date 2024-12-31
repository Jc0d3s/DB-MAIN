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
  <div class="container mx-auto py-10">
  <!-- Contact Us Section -->
  <div class="text-center bg-blue-800 text-white py-6">
    <h2 class="text-xl font-bold">If you have any query related to investment... we are available 24/7</h2>
    <button class="mt-4 px-6 py-2 bg-white text-blue-800 font-semibold rounded">Contact Us</button>
  </div>

  <!-- Add Space Between Sections -->
  <div class="mt-12">
    <h2 class="text-3xl font-bold text-center mb-10">Things You Get</h2>
  
    <section class="py-16 bg-gray-50">
    <div class="container mx-auto px-4">
      <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-8">
        <!-- Card 1 -->
        <div class="flex flex-col items-center text-center p-6 bg-white rounded-lg shadow">
          <div class="mb-4">
            <img src="public\assets\wand-magic-sparkles-solid.svg" alt="Creative Support Icon" class="h-12 w-12" />
          </div>
          <h3 class="text-lg font-semibold text-gray-800">Creative Support</h3>
          <p class="text-sm text-gray-600 mt-2">
            We transform brands, grow businesses, and tell brand and product stories in the most creative way.
          </p>
        </div>

        <!-- Card 2 -->
        <div class="flex flex-col items-center text-center p-6 bg-white rounded-lg shadow">
          <div class="mb-4">
            <img src="public\assets\cloud-arrow-up-solid.svg" alt="Creating Experiences Icon" class="h-12 w-12" />
          </div>
          <h3 class="text-lg font-semibold text-gray-800">Creating Experiences</h3>
          <p class="text-sm text-gray-600 mt-2">
            We cover a large range of creative platforms and digital projects with one purpose: to create experiences.
          </p>
        </div>

        <!-- Card 3 -->
        <div class="flex flex-col items-center text-center p-6 bg-white rounded-lg shadow">
          <div class="mb-4">
            <img src="public\assets\bullseye-solid.svg" alt="Product Consulting Icon" class="h-12 w-12" />
          </div>
          <h3 class="text-lg font-semibold text-gray-800">Product Consulting</h3>
          <p class="text-sm text-gray-600 mt-2">
            We guide you through the pipelines that generate new products with higher potential and lower risk.
          </p>
        </div>

        <!-- Card 4 -->
        <div class="flex flex-col items-center text-center p-6 bg-white rounded-lg shadow">
          <div class="mb-4">
            <img src="public\assets\globe-solid.svg" alt="Business Boosting Icon" class="h-12 w-12" />
          </div>
          <h3 class="text-lg font-semibold text-gray-800">Business Boosting</h3>
          <p class="text-sm text-gray-600 mt-2">
            We provide energy-efficient and environmentally conservative solutions to our clients to boost their business.
          </p>
        </div>

        <!-- Card 5 -->
        <div class="flex flex-col items-center text-center p-6 bg-white rounded-lg shadow">
          <div class="mb-4">
            <img src="public\assets\money-bill-solid.svg" alt="Strategic Approach Icon" class="h-12 w-12" />
          </div>
          <h3 class="text-lg font-semibold text-gray-800">Strategic Approach</h3>
          <p class="text-sm text-gray-600 mt-2">
            Based on solid strategic framework and real, relevant research, we create prototypes, not presentations.
          </p>
        </div>

        <!-- Card 6 -->
        <div class="flex flex-col items-center text-center p-6 bg-white rounded-lg shadow">
          <div class="mb-4">
            <img src="public\assets\chart-simple-solid.svg" alt="Logistic Consulting Icon" class="h-12 w-12" />
          </div>
          <h3 class="text-lg font-semibold text-gray-800">Logistic Consulting</h3>
          <p class="text-sm text-gray-600 mt-2">
            We work buy side and sell side to give our clients hard-hitting answers and focus hard on best opportunities.
          </p>
        </div>
      </div>
    </div>
  </section>

    <!-- Grid Section -->
    <div class="grid grid-cols-1 md:grid-cols-3 gap-8 px-8 text-center">
      <div v-for="item in features" :key="item.title" class="space-y-4">
        <!-- Icon -->
        <div class="flex justify-center items-center">
          <component :is="item.icon" class="w-12 h-12 text-blue-500" />
        </div>
        <!-- Title -->
        <h3 class="text-xl font-semibold">{{ item.title }}</h3>
        <!-- Description -->
        <p class="text-gray-600" v-html="item.description"></p>
      </div>
    </div>
  </div>
</div>

<div class="bg-blue-900 text-white min-h-screen flex items-center justify-center">
    <div class="bg-blue-800 p-8 rounded-lg shadow-lg w-full max-w-4xl flex flex-col md:flex-row">
      <!-- Left Section -->
      <div class="md:w-1/2 p-6 border border-yellow-500 rounded-lg mb-6 md:mb-0 md:mr-6">
        <h2 class="text-2xl font-bold mb-4">Request a call back</h2>
        <p class="text-gray-300">
          Would you like to speak to one of our financial advisers over the phone? Just submit your details, and we’ll be in touch shortly. You can also email us if you would prefer.
        </p>
      </div>
      <!-- Right Section -->
      <div class="md:w-1/2 bg-blue-700 p-6 rounded-lg">
        <h3 class="text-xl font-semibold mb-4">I would like to discuss:</h3>
        <form class="space-y-4">
          <div class="flex space-x-4">
            <input
              type="text"
              placeholder="Your Name"
              class="w-1/2 p-3 rounded-lg bg-white text-gray-800"
            />
            <input
              type="text"
              placeholder="Phone Number"
              class="w-1/2 p-3 rounded-lg bg-white text-gray-800"
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

  <div class="container mx-auto px-6 py-12">
    <h1 class="text-4xl font-bold text-center mb-12">Global Leadership</h1>
    <div class="grid grid-cols-1 md:grid-cols-3 gap-8">
      <div v-for="member in team" :key="member.name" class="text-center">
        <img :src="member.image" alt="Team Member" class="w-full h-64 object-cover rounded-lg shadow-lg">
        <h2 class="text-2xl font-bold mt-6">{{ member.name }}</h2>
        <p class="text-gray-500">{{ member.role }}</p>
        <p class="mt-4 text-gray-700">{{ member.description }}</p>
      </div>
    </div>
  </div>


<div class="relative bg-gray-800 text-white h-screen">
  <!-- Background Section -->
  <div class="absolute inset-0 flex justify-center items-center">
    <img
      src="public/assets/background-15.jpg"
      alt="Background"
      class="w-full max-h-[80vh] object-cover opacity-50"
    />
  </div>

  <!-- Content Section -->
  <div class="relative z-10 flex flex-col items-center justify-center h-full text-center px-8 lg:px-16">
    <h1 class="text-4xl lg:text-6xl font-bold mb-8">
      <ion-icon name="checkmark-done-outline" class="text-yellow-400 align-middle mr-2"></ion-icon>
      Take the <span class="text-yellow-400">right step</span>,<br />
      do the big things.
    </h1>

    <div class="grid grid-cols-2 md:grid-cols-4 gap-6 mb-8">
      <div>
        <p class="text-3xl font-bold">52k</p>
        <p class="text-gray-300">Cases Solved</p>
      </div>
      <div>
        <p class="text-3xl font-bold">164</p>
        <p class="text-gray-300">Trained Experts</p>
      </div>
      <div>
        <p class="text-3xl font-bold">38</p>
        <p class="text-gray-300">Branches</p>
      </div>
      <div>
        <p class="text-3xl font-bold">100%</p>
        <p class="text-gray-300">Satisfied Clients</p>
      </div>
    </div>
  </div>
</div>

<!-- Testimonial Section -->
<div class="relative max-w-6xl mx-auto p-8 bg-white shadow-lg rounded-lg mt-16">
  <!-- Testimonial Content -->
  <div v-for="(testimonial, index) in testimonials" :key="index" v-show="currentIndex === index" class="flex items-center space-x-6">
    <!-- Image -->
    <img :src="testimonial.image" alt="Profile Picture" class="w-48 h-48 rounded-full object-cover">
    <!-- Text -->
    <div>
      <p class="text-gray-700 text-lg">{{ testimonial.quote }}</p>
      <p class="mt-2 font-bold text-gray-900">{{ testimonial.name }}</p>
      <p class="text-sm text-gray-500">{{ testimonial.position }}</p>
    </div>
  </div>

  <!-- Navigation Arrows -->
  <button
    @click="prevTestimonial"
    class="absolute left-0 top-1/2 transform -translate-y-1/2 bg-transparent text-black p-4 rounded-full shadow-lg hover:bg-gray-300 focus:outline-none "
  >
    <span class="text-black text-3xl">
      &#10094; <!-- Left arrow symbol -->
    </span>
  </button>

  <button
    @click="nextTestimonial"
    class="absolute right-0 top-1/2 transform -translate-y-1/2 bg-transparent text-black p-4 rounded-full shadow-lg hover:bg-gray-300 focus:outline-none "
  >
    <span class="text-black text-3xl">
      &#10095; <!-- Right arrow symbol -->
    </span>
  </button>
</div>


<!-- Logos Section -->
<section class="bg-gray-100 py-16">
  <div class="container mx-auto grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 gap-8 items-center">
    <div v-for="logo in logos" :key="logo.name" class="flex justify-center">
      <img :src="logo.src" :alt="logo.name" class="h-24 object-contain" />
    </div>
  </div>
</section>


<div class="bg-gray-100 py-10">
    <div class="max-w-7xl mx-auto px-4">
      <h2 class="text-3xl font-bold text-center mb-8 text-gray-800 mb-8">Latest News</h2>
      <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
        <div
          v-for="(news, index) in newsItems"
          :key="index"
          class="bg-white rounded-lg shadow-lg overflow-hidden"
        >
          <img
            :src="news.image"
            :alt="news.title"
            class="w-full h-50 object-cover"
          />
          <div class="p-6">
            <h3 class="text-lg font-semibold text-gray-800">{{ news.title }}</h3>
            <p class="text-sm text-gray-500 mb-4">By {{ news.author }}</p>
            <p class="text-gray-600 mb-4">{{ news.description }}</p>
            <a
              :href="news.link"
              class="text-blue-600 hover:underline font-semibold flex items-center"
            >
              Learn More <span class="ml-2">&rarr;</span>
            </a>
          </div>
        </div>
      </div>
    </div>
  </div>

  <footer class="bg-blue-900 text-white py-8">
    <div class="container mx-auto px-4">
      <div class="flex flex-wrap justify-between">
        <!-- Signup Section -->
        <div class="w-full md:w-1/2 lg:w-1/3">
          <h2 class="text-2xl font-bold">Sign up for email alerts</h2>
          <p class="mt-2 text-sm">Stay current with our latest insights</p>
          <div class="mt-4 flex">
            <input
              type="email"
              placeholder="Enter Email Here"
              class="w-full md:w-auto flex-grow px-4 py-2 rounded-l-md focus:outline-none"
            />
            <button
              class="bg-yellow-500 text-black px-6 py-2 rounded-r-md hover:bg-yellow-600"
            >
              Submit
            </button>
          </div>
        </div>

        <!-- Links Section -->
        <div class="w-full md:w-1/4 lg:w-1/5 mt-8 md:mt-0">
          <ul>
            <li class="mb-2"><a href="#" class="hover:underline">Contact Us</a></li>
            <li class="mb-2"><a href="#" class="hover:underline">FAQ</a></li>
            <li class="mb-2"><a href="#" class="hover:underline">Privacy Policy</a></li>
            <li class="mb-2"><a href="#" class="hover:underline">Terms of Use</a></li>
            <li class="mb-2"><a href="#" class="hover:underline">Global Office</a></li>
            <li><a href="#" class="hover:underline">Local Office</a></li>
          </ul>
        </div>

        <!-- Social Media Section -->
        <div class="w-full md:w-1/4 lg:w-1/5 mt-8 md:mt-0">
          <ul>
            <li class="mb-2 flex items-center">
              <span class="w-6 h-6 bg-blue-800 rounded-full flex items-center justify-center mr-2">
                <i class="fab fa-linkedin"></i>
              </span>
              <a href="#" class="hover:underline">Linkedin</a>
            </li>
            <li class="mb-2 flex items-center">
              <span class="w-6 h-6 bg-blue-800 rounded-full flex items-center justify-center mr-2">
                <i class="fab fa-twitter"></i>
              </span>
              <a href="#" class="hover:underline">Twitter</a>
            </li>
            <li class="mb-2 flex items-center">
              <span class="w-6 h-6 bg-blue-800 rounded-full flex items-center justify-center mr-2">
                <i class="fab fa-facebook"></i>
              </span>
              <a href="#" class="hover:underline">Facebook</a>
            </li>
            <li class="flex items-center">
              <span class="w-6 h-6 bg-blue-800 rounded-full flex items-center justify-center mr-2">
                <i class="fab fa-google-plus"></i>
              </span>
              <a href="#" class="hover:underline">Google+</a>
            </li>
          </ul>
        </div>
      </div>
      <!-- Footer Bottom -->
      <div class="mt-8 flex flex-col md:flex-row justify-between items-center text-sm">
  <!-- Left: Logo -->
  <div class="flex items-center">
    <img src="public/assets/logo-light.png" alt="Logo" class="h-8 mr-2" />
  </div>

  <!-- Center: Copyright -->
  <div class="mt-4 md:mt-0">
    <p>© Copyright 2018 Elixir Inc.</p>
  </div>

  <!-- Right: Designed by -->
  <div class="mt-4 md:mt-0">
    <p>Designed by Themewagon</p>
  </div>
</div>
</div>
</footer>


</template>

<script>
export default {
  name: "CombinedComponents",
  data() {
    return {
      // Data for Hero Section
      currentHeader: 0,
      headers: [
        {
          image: "/assets/header-5.jpg",
          title: "Expert Consultants",
          description:
            "Over 10 years of experience in helping clients<br>find comprehensive solutions.",
          button1: { text: "Read More", link: "#" },
          button2: { text: "Contact Us", link: "contact.html" },
          textClass: "text-white",
        },
        {
          image: "/assets/header-1.jpg",
          title: "Growth Partners",
          description:
            "Connect with top consultants hand-picked by<br> Elixir consulting and finance.",
          button1: { text: "Our Services", link: "services.html" },
          button2: { text: "Get Started", link: "start.html" },
          textClass: "text-white",
        },
        {
          image: "/assets/header-6.jpg",
          title: "Helping Leaders",
          description:
            "We look forward to help you in taking your <br>company to new height.",
          button1: { text: "Learn More", link: "#" },
          button2: { text: "Join Us", link: "join.html" },
          textClass: "text-white",
        },
      ],

      // Data for Testimonials Section
      currentIndex: 0,
      testimonials: [
        {
          image: "/assets/client1.png",
          quote:
            "As a sales gamification company, we were skeptical to work with a consultant to optimize our sales emails, but Elixir was highly recommended by many other Y-Combinator startups we knew.",
          name: "David Beckham",
          position: "Chairman, Harmony Corporation",
        },
        {
          image: "/assets/client2.png",
          quote:
            "Writing case studies was a daunting task for us. We didn’t know where to begin or what questions to ask. Elixir team did everything with almost no effort from me!",
          name: "Maria Sharapova",
          position: "Managing Director, Themewagon Inc.",
        },
        {
          image: "/assets/client3.png",
          quote:
            "Their work on our website and Internet marketing has made a significant difference to our business. We've seen a 425% increase in quote requests from the website which has been pretty remarkable - but I'd always like to see more!",
          name: "Michael Clarke",
          position: "CEO, A.E.T Institute",
        },
      ],

      // Data for Logo Section
      logos: [
        { name: "Partnerco", src: "/assets/logo1.png" },
        { name: "TVC Marketing", src: "/assets/logo2.png" },
        { name: "Arcade", src: "/assets/logo3.png" },
        { name: "Bearbrand", src: "/assets/logo4.png" },
        { name: "Haircuts & Beards", src: "/assets/logo5.png" },
        { name: "Vice", src: "/assets/logo6.png" },
      ],

      // Data for Latest News Section
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

      // Data for Team Section
      team: [
        {
          name: 'Reenal Scott',
          role: 'Advertising Consultant',
          description: 'Reenal Scott is the Founder and CEO of Elixir, which he started from his dorm room in 2013 with 3 people only.',
          image: '/assets/portrait-1.jpg',
        },
        {
          name: 'Lily Anderson',
          role: 'Activation Consultant',
          description: 'Lily leads Elixir UK and oversees the company’s Customer Operations teams supporting millions of users.',
          image: '/assets/portrait-6.jpg',
        },
        {
          name: 'Thomas Anderson',
          role: 'Change Management Consultant',
          description: 'As the VP of People, Thomas’s focus lies in the development and optimization of talent retention.',
          image: '/assets/portrait-3.jpg',
        },
        {
          name: 'Legartha Mantana',
          role: 'Brand Management Consultant',
          description: 'As General Counsel of Elixir, Tony oversees global legal activities and policies across all aspects.',
          image: '/assets/portrait-4.jpg',
        },
        {
          name: 'John Snow',
          role: 'Business Analyst',
          description: 'John has overseen the meteoric growth while protecting scaling its uniquely creative and culture.',
          image: '/assets/portrait-5.jpg',
        },
        {
          name: 'Ragner Lothbrok',
          role: 'Business Consultant',
          description: 'Ragner, SVP of Engineering, oversees Elixir’s vast engineering organization which drives the core programming.',
          image: '/assets/portrait-7.jpg',
        },
      ],
    };
  },
  methods: {
    // Hero Section Methods
    nextHeader() {
      this.currentHeader = (this.currentHeader + 1) % this.headers.length;
    },
    previousHeader() {
      this.currentHeader =
        (this.currentHeader - 1 + this.headers.length) % this.headers.length;
    },

    // Testimonials Section Methods
    prevTestimonial() {
      this.currentIndex =
        (this.currentIndex - 1 + this.testimonials.length) %
        this.testimonials.length;
    },
    nextTestimonial() {
      this.currentIndex =
        (this.currentIndex + 1) % this.testimonials.length;
    },
  },
};
</script>

<style scoped>

@import "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css";
@import "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css";
@import url("https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css");

</style>


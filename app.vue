<template>
  <div>
    <ContactInfoBar />
    <NavigationBar />
    <HeroSection />
    <ServicesSection />
    <WhyChooseUs />
    <CallToAction />
    <Team />
    <Testimonials />
    <Logo />
    <NewsSection />
    <Footer />
  </div>
</template>

<script>
import ContactInfoBar from "./components/ContactInfoBar.vue";
import NavigationBar from "./components/NavigationBar.vue";
import HeroSection from "./components/HeroSection.vue";
import ServicesSection from "./components/ServicesSection.vue";
import WhyChooseUs from "./components/WhyChooseUs.vue";
import CallToAction from "./components/CallToAction.vue";
import Team from "./components/Team.vue";
import Testimonials from "./components/Testimonials.vue";
import Logo from "./components/Logo.vue";
import NewsSection from "./components/NewsSection.vue";
import Footer from "./components/Footer.vue";

export default {
  name: "App",
  components: {
    ContactInfoBar,
    NavigationBar,
    HeroSection,
    ServicesSection,
    WhyChooseUs,
    CallToAction,
    Team,
    Testimonials,
    Logo,
    NewsSection,
    Footer,
  },
};
</script>

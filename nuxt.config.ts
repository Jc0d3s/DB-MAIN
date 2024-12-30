export default defineNuxtConfig({
  css: [
    '@/assets/styles.css',
  ],

  postcss: {
    plugins: {
      tailwindcss: {},
      autoprefixer: {},
    }
  },

  compatibilityDate: '2024-12-27',

  app: {
    head: {
      link: [
        {
          rel: 'stylesheet',
          href: 'https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css'
        }
      ]
    }
  },
});
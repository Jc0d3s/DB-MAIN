/** @type {import('tailwindcss').Config} */
export default {
  content: [
    './components/**/*.{vue,js,ts}',
    './layouts/**/*.vue',
    './pages/**/*.vue',
    './plugins/**/*.{js,ts}',
    './app.vue',
    './assets/**/*.css',
    './nuxt.config.{js,ts}',
  ],
  theme: {
    extend: {
      keyframes: {
        popUp: {
          '0%': { opacity: 0, transform: 'translateY(20px)' },
          '100%': { opacity: 1, transform: 'translateY(0)' },
        },
      },
      animation: {
        'pop-up': 'popUp 0.5s ease-out',
      },
    },
  },
  plugins: [],
}


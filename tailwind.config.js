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
          '0%': { transform: 'scale(0.8)', opacity: '0' },
          '100%': { transform: 'scale(1)', opacity: '1' },
        },
      },
      animation: {
        'pop-up': 'popUp 0.5s ease-out',
      },
    },
  },
  plugins: [],
}


import { defineStore } from 'pinia';

interface Header {
  image: string;
  title: string;
  description: string;
}

export const useHeaderStore = defineStore('header', {
  state: () => ({
    headers: [
      {
        image: '/assets/header-5.jpg',
        title: 'Expert Consultants',
        description: 'Over 10 years of experience in helping clients<br>find comprehensive solutions.',
      },
      {
        image: '/assets/header-1.jpg',
        title: 'Growth Partners',
        description: 'Connect with top consultants hand-picked by<br> Elixir consulting and finance.',
      },
      {
        image: '/assets/header-6.jpg',
        title: 'Helping Leaders',
        description: 'We look forward to helping you in taking <br>your company to new heights.',
      },
    ] as Header[],
    currentHeader: 0,
  }),
  actions: {
    nextHeader() {
      this.currentHeader = (this.currentHeader + 1) % this.headers.length;
    },
    previousHeader() {
      this.currentHeader =
        (this.currentHeader - 1 + this.headers.length) % this.headers.length;
    },
  },
});

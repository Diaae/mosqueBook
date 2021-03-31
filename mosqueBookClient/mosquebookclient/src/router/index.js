import Vue from 'vue'
import Router from 'vue-router'
const Home = () => import('@/components/Home')
const Booking = () => import('@/components/Booking')
const Events = () => import('@/components/Events')

Vue.use(Router);
const routes = [
    { path: '/', redirect: '/home' },
    { path: '/home', component: Home },
    { path: '/booking', component: Booking },
    { path: '/events', component: Events },
  ]
const router = new Router({
    mode: 'hash', // https://router.vuejs.org/api/#mode
    linkActiveClass: 'open active',
    routes
});

export default router
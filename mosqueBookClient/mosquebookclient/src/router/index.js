import Vue from 'vue'
import Router from 'vue-router'
const Home = () => import('@/components/Home')
const Booking = () => import('@/components/Booking')

Vue.use(Router);
const routes = [
    { path: '/', redirect: '/home' },
    { path: '/home', component: Home },
    { path: '/booking', component: Booking },
  ]
const router = new Router({
    mode: 'hash', // https://router.vuejs.org/api/#mode
    linkActiveClass: 'open active',
    routes
});

export default router
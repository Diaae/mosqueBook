import Vue from 'vue'
import Router from 'vue-router'
const Home = () => import('@/components/Home')
const Booking = () => import('@/components/Booking')
const Events = () => import('@/components/Events')
const Mosques = () => import('@/components/Mosque')
const MosquesAdd = () => import('@/components/MosqueAdd')

Vue.use(Router);
const routes = [
    { path: '/', redirect: '/home' },
    { name: 'Home', path: '/home', component: Home },
    { name: "Booking", path: '/booking', component: Booking },
    { name: "Events", path: '/events', component: Events },
    { name: "Mosques", path: '/mosque', component: Mosques },
    { name: "MosquesAdd", path: '/mosque-add', component: MosquesAdd},
  ]
const router = new Router({
    mode: 'hash', // https://router.vuejs.org/api/#mode
    linkActiveClass: 'open active',
    routes
});

export default router
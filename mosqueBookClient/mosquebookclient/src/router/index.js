import Vue from 'vue'
import Router from 'vue-router'
const Home = () => import('@/components/Home')
const Booking = () => import('@/views/Booking')
const Events = () => import('@/views/Events')
const Mosques = () => import('@/views/Mosque')
const MosquesAdd = () => import('@/views/MosqueAdd')
const Appointments = () => import('@/views/Appointments')
const AppointmentList = () => import('@/views/AppointmentList')

Vue.use(Router);
const routes = [
    { path: '/', redirect: '/home' },
    { name: 'Home', path: '/home', component: Home },
    { name: "Booking", path: '/booking/:eventId', props: true, component: Booking },
    { name: "Events", path: '/events', component: Events },
    { name: "Mosques", path: '/mosque', component: Mosques },
    { name: "MosquesAdd", path: '/mosque-add', component: MosquesAdd},
    { name: "Appointments", path: '/appointments', component: Appointments},
    { name: "AppointmentList", path: '/appointmentList', component: AppointmentList},
  ]
const router = new Router({
    mode: 'hash', // https://router.vuejs.org/api/#mode
    linkActiveClass: 'open active',
    routes
});

export default router
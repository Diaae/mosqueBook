import Vue from 'vue'
import Router from 'vue-router'
import api from '@/shared/data.service'
const Home = () => import('@/components/Home')
const Login = () => import('@/views/Login')
const Booking = () => import('@/views/Booking')
const Events = () => import('@/views/Events')
const Mosques = () => import('@/views/Mosque')
const MosquesAdd = () => import('@/views/MosqueAdd')
const Cancellation = () => import('@/views/CancelAppointment')
const Appointments = () => import('@/views/Appointments')
const AppointmentList = () => import('@/views/AppointmentList')

Vue.use(Router);
const routes = [
  { path: '/', redirect: '/home' },
  { name: 'Home', path: '/home', component: Home },
  { name: 'Login', path: '/login', component: Login },
  { name: "Booking", path: '/booking/:eventId', props: true, component: Booking },
  { name: "Events", path: '/mosque/:mosqueId/events', component: Events },
  { name: "Mosques", path: '/mosque', component: Mosques },
  { name: "MosquesAdd", path: '/mosque-add', component: MosquesAdd },
  { name: "Cancellation", path: '/cancellation', component: Cancellation },
  { name: "Appointments", path: '/appointments', component: Appointments },
  { name: "AppointmentList", path: '/appointmentList/event/:eventId/group/:groupId', component: AppointmentList },
]
const router = new Router({
  //mode: 'hash', // https://router.vuejs.org/api/#mode
  
  linkActiveClass: 'open active',
  routes
});


router.beforeEach(async (to, from, next) => {
  if (to.name === 'AppointmentList' || to.name === 'Appointments') {
    let token = localStorage.getItem("token");
    console.log(token);
    if (token != null) {
      api.post('users/validate/' + token, {}, (response) => {
        
        if (response.status === 200) {
          console.log(response);
        }
        next();
      },()=>{
        console.log('Im here');
        next({ path: '/login' });
        
      });

     

    } else {
      next({ path: '/login' });
    }
  }else
    next();
  // ...

});
export default router
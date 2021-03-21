import Vue from 'vue'
import Router from 'vue-router'
const Home = () => import('@/components/Home')

Vue.use(Router);
const routes = [
    { path: '/home', component: Home },
    { path: '/', redirect: '/home' }
  ]
const router = new Router({
    mode: 'hash', // https://router.vuejs.org/api/#mode
    linkActiveClass: 'open active',
    routes
});

export default router
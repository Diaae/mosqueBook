import Vue from 'vue'
import App from './App.vue'
import { BootstrapVue } from 'bootstrap-vue'
import router from './router'

Vue.config.productionTip = false

// Import Bootstrap an BootstrapVue CSS files (order is important)
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'
import i18n from './i18n'

// Make BootstrapVue available throughout your project
Vue.use(BootstrapVue)
new Vue({
  render: h => h(App),
  i18n,
  router
}).$mount('#app')

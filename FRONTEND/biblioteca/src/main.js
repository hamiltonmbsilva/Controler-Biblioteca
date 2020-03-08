import Vue from 'vue';
import App from './App.vue';
import BootstrapVue from "bootstrap-vue";
import VueRouter from "vue-router";
import "bootstrap/dist/css/bootstrap.css";
import "bootstrap-vue/dist/bootstrap-vue.css";

Vue.use(VueRouter);
Vue.use(BootstrapVue);

Vue.config.productionTip = false

import Login from "./pages/login.vue";

const routes = [
  {path: "/login", component: Login}
];

const router = new VueRouter({
  routes,
  mode: "history" //remove o # da url
});

new Vue({
  router,
  el:"#app",
  render: h => h(App),
}).$mount('#app')

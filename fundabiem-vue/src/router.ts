import Vue from 'vue'
import Router from 'vue-router'
import HomePage from './components/PaginaInicio/HomePage.vue'
import toolbarhp from './components/PaginaInicio/toolbarhp.vue'

Vue.use(Router)

export default new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/',
      name: 'HomePage',
      component: HomePage
    },
    {
      path: '/toolbarhp',
      name: 'toolbarhp',
      component: toolbarhp
    }
  ]
})

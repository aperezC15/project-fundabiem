import Vue from 'vue'
import Router from 'vue-router'
import HomePage from './components/PaginaInicio/HomePage.vue'
import toolbarhp from './components/PaginaInicio/toolbarhp.vue'
import footerhp from './components/PaginaInicio/footerhp.vue'
import HomePageRM from './components/PaginaRegistroMedico/HomePageRM.vue'
import HomePageET from './components/EvolucionTecnica/HomePageET.vue'
import HomePageES from './components/EstudioSocioeconomico/HomePageES.vue'

Vue.use(Router)

export default new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/toolbarhp',
      name: 'toolbarhp',
      component: toolbarhp
    },
    {
      path: '/',
      name: 'HomePage',
      component: HomePage
    },
    {
      path: '/footerhp',
      name: 'footerhp',
      component: footerhp
    },
    {
      path: '/HomePageRM',
      name: 'HomePageRM',
      component: HomePageRM
    },
    {
      path: '/HomePageET',
      name: 'HomePageET',
      component: HomePageET
    },
    {
      path: '/HomePageES',
      name: 'HomePageES',
      component: HomePageES
    }


  ]
})

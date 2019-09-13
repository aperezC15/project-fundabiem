import Vue from 'vue'
import Router from 'vue-router'
import HomePage from './components/PaginaInicio/HomePage.vue'
import toolbarhp from './components/PaginaInicio/toolbarhp.vue'
import footerhp from './components/PaginaInicio/footerhp.vue'
import HomePageRM from './components/PaginaRegistroMedico/HomePageRM.vue'
import HomePageET from './components/EvolucionTecnica/HomePageET.vue'
import HomePageES from './components/EstudioSocioeconomico/HomePageES.vue'
import Callback from './components/oidc/callback.vue'

//@ts-ignore
import { vuexOidcCreateRouterMiddleware } from 'vuex-oidc'
import axios, { AxiosResponse } from 'axios'
import store from '@/store'
Vue.use(Router)

const router = new Router({
  mode: 'history',
  base:`${process.env.VUE_APP_ROUTER_ROOT_PATH}`,
  routes: [
    {
      path: '/toolbarhp',
      name: 'toolbarhp',
      component: toolbarhp
    },
    {
      path: '/',
      name: 'HomePage',
      component: HomePage,
      meta:{
        isPulic: true
      }
    },
    {
      path: '/oidc-callback', // Needs to match redirect_uri in you oidcSettings
      name: 'oidcCallback',
      component: Callback,
      meta: {
          isOidcCallback: true,
          isPublic: true
      }
    },
    {
      path: '/footerhp',
      name: 'footerhp',
      component: footerhp,
      meta:{
        isPulic:false
      }
    },
    {
      path: '/RegistroMedico',
      name: 'RegistroMedico',
      component: HomePageRM,
      meta:{
        isPulic: false
      }
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
router.beforeEach(vuexOidcCreateRouterMiddleware(store, 'oidcStore'))

export default router
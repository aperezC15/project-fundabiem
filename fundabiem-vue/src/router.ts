import Vue from 'vue'
import Router from 'vue-router'
import hello from './components/HelloWorld.vue'
import Callback from './components/oidc/callback.vue'
import callbackError from './components/oidc/callbackError.vue'
import HomePage from './components/PaginaInicio/HomePage.vue'
import toolbarhp from './components/PaginaInicio/toolbarhp.vue'
import footerhp from './components/PaginaInicio/footerhp.vue'
import HomePageRM from './components/PaginaRegistroMedico/HomePageRM.vue'
import HomePageET from './components/EvolucionTecnica/HomePageET.vue'
import HomePageES from './components/EstudioSocioeconomico/HomePageES.vue'
import HomePageHC from './components/HistoriaClinica/PageHistoryClinic.vue'
import HistoriaClinicaPsicologia from './components/Historia-Clinica-Psicologia/HistoriaClinicaPsicologia.vue'

import CicloRehabilitacion from './views/Ciclo_Rehabilitacion/Ciclo_de_Rehabilitacion.vue'


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
      component: toolbarhp,
      meta:{
        isPulic:true
      }
    },
    // {
    //   path: '/dashboard',
    //   name:'dashboard',
    //   component: hello,
    //   meta: {
    //     isPublic:false
    //   }
    // },
    {
      path: '/',
      name: 'home',
      component: HomePage,
      meta:{
        //requiresAuth: false,
        isPublic:true
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
      path: '/oidc-callback-error', // Needs to match redirect_uri in you oidcSettings
      name: 'oidcCallbackError',
      component: callbackError,
      meta: {
          isPublic: true
      }
  },
    {
      path: '/footerhp',
      name: 'footerhp',
      component: footerhp,
      meta:{
        isPulic:true
      }
    },
    {
      path: '/HomePageRM',
      name: 'HomePageRM',
      component: HomePageRM,
      meta:{
        requiresAuth: false,
        isPulic: true
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
    },
    {
      path: '/HomePageHC',
      name: 'HomePageHC',
      component: HomePageHC
    },
    {
      path: "/ciclo-rehabilitacion",
      name:'/ciclo-rehabilitacion',
      component: CicloRehabilitacion
    },
    {
      path: "/Psicologia-clinica",
      name: "/Psicologia-clinica",
      component: HistoriaClinicaPsicologia
    }
  ]
})

router.beforeEach(vuexOidcCreateRouterMiddleware(store, 'oidcStore'))

export default router
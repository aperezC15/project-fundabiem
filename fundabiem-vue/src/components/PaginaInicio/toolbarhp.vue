<template>
    <div id="app">        
        <!-- start  of the toolbar -->
        <v-app-bar color="#2c2e3f" dark clipped-left app>
            <div>
                <v-avatar>
                  <v-img src="http://www.fundabiem.org.gt/wp-content/uploads/2017/08/favcon.jpg"> </v-img>
                </v-avatar>
            </div>
            <v-toolbar-title  class="headline text-uppercase">
                <span>FUNDABIEM RETALHULEU</span>
            </v-toolbar-title>

            <v-spacer></v-spacer>
            <v-tooltip bottom color="indigo">
              <template v-slot:activator="{ on }">
                <v-btn v-on="on" class="mx-2"  fab color="indigo" @click="signOutOidc" v-if="oidcIsAuthenticated" >
                  <v-icon>fas fa-power-off</v-icon>
                </v-btn>
              </template>
              <span>Cerrar Sesión</span>
            </v-tooltip>
            
            <v-btn class="mx-2" title="Iniciar Sesion" fab color="indigo" to="/dashboard" v-if="!oidcIsAuthenticated" >
                <v-icon>fas fa-sign-in-alt</v-icon>
            </v-btn>
        </v-app-bar>        
        <!-- end of the toolbar -->
          
          <v-navigation-drawer expand-on-hover app clipped 
          hide-overlay
          width="300px"
          v-if="oidcIsAuthenticated"
          v-model="drawer"
          :mini-variant.sync="mini"
          >
          <v-card>
            <v-list shaped>
              <v-list-item>
                <v-list-item-avatar>
                  <v-img src="img/user.png"></v-img>
                </v-list-item-avatar>
                  <v-list-title>{{userName}}</v-list-title>
              </v-list-item>                
              <v-list-item-group v-model="item" color="blue darken-1">
                <v-list-item
                  v-for="(item, i) in items"
                  :key="i" :to="item.path"
                >
                  <v-list-item-icon>
                    <v-icon v-text="item.icon"></v-icon>
                  </v-list-item-icon>
                  <v-list-item-content>
                    <v-list-item-title v-text="item.title"></v-list-item-title>
                  </v-list-item-content>
                </v-list-item>
              </v-list-item-group>
            </v-list>
          </v-card>
          </v-navigation-drawer>
    </div>
    
</template>

<script lang="ts" >
import { mapGetters, mapActions } from 'vuex'; 
import { Component, Vue } from 'vue-property-decorator'
const namespace: string = 'oidcStore/';

 @Component({
   computed: {
      ...mapGetters('oidcStore', [
                'oidcIsAuthenticated',
                'oidcUser'
            ])
    },
    methods: {
      ...mapActions('oidcStore', ['authenticateOidcSilent',
                'signOutOidc', 'authenticateOidc'])
    },
})

export default class tool extends Vue{

    drawer:boolean=true
    mini:boolean=true
    userName:string = ''
    item:number=1
    items:any=[
        // { title: 'Registros Medicos' , icon: 'far fa-address-card', path: '/HomePageRM'},
        { title: 'Estudio Socioeconomico' , icon: 'far fa-address-card', path: '/HomePageES'},
        // { title: 'Hoja Evolución Técnica ' , icon: 'far fa-address-card', path: '/HomePageET'},
        // { title: 'Hoja de Estadísticas Diarias' , icon: 'far fa-address-card', path: ''},
        { title: 'Evolución médica', icon: "far fa-folder", path:'/evolucion-medica'},
        { title: 'Citas', icon: "far fa-folder", path:'/citas'},
        { title: 'Ciclo de Rehabilitacion', icon: "far fa-address-card", path:'/ciclo-rehabilitacion'},
        { title: 'Historia Clínica Psicologia', icon: "far fa-address-card", path:'/Psicologia-clinica'},
        { title: 'Registros Médicos', icon: "far fa-folder", path:'/registro-medico'},
        { title: 'Historia Clínica', icon: "far fa-folder", path:'/historia-clinica'},
    ]

    // mounted() {
    //     const user = this.$store.getters[namespace + 'oidcUser'];
    //     var nombre = user.name.split('@')
    //     var apellido = nombre[1].split('@')
    //     this.userName = nombre[0]; 
    // }
}
</script>

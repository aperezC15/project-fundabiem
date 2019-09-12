<template>
    <div id="app">        
        <v-app-bar 
        color="#2c2e3f" 
        dark 
        app>
            <v-app-bar-nav-icon title="MENU" @click.stop="drawer = !drawer"></v-app-bar-nav-icon>         
            <div>
                <v-avatar>
                  <v-img src="http://www.fundabiem.org.gt/wp-content/uploads/2017/08/favcon.jpg"> </v-img>
                </v-avatar>
            </div>
            <v-toolbar-title  class="headline text-uppercase">
                <span>FUNDABIEM RETALHULEU</span>
            </v-toolbar-title>

            <v-spacer></v-spacer>
            
            <v-btn class="mx-2" title="SALIR DEL SISTEMA" fab color="indigo" to="">
                <v-icon>fas fa-power-off</v-icon>
            </v-btn>
        </v-app-bar>        

        <v-navigation-drawer app clipped
        mini-variant.sync="mini"
        hide-overlay
        v-model="drawer"
        absolute
        temporary    
        width="300px"
        >
        <v-card
          class="mx-auto"
        >
          <v-list shaped>
            <v-subheader>REPORTS</v-subheader>
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

<script lang="ts">
import Vue from 'vue';

export default({
    name: 'App',
    data: () => ({
      drawer: false, 

      //AQUI MOSTRAMOS LAS OPCIONES EN EL MENU
      item: 1,
      items: [
          { title: 'Registros Medicos' , icon: 'far fa-address-card', path: '/HomePageRM'},
          { title: 'Estudio Socioeconomico' , icon: 'far fa-address-card', path: '/HomePageES'},
          { title: 'Hoja Evolución Técnica ' , icon: 'far fa-address-card', path: '/HomePageET'},
          { title: 'Hoja de Estadísticas Diarias' , icon: 'far fa-address-card', path: ''},
      ]
    }),

});
</script>

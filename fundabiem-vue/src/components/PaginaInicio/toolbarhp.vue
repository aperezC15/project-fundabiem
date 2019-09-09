<template>
    <div id = "app">        
        <v-app-bar 
        color="blue" 
        dark 
        app>
            <v-app-bar-nav-icon title="MENU" @click.stop="drawer = !drawer"></v-app-bar-nav-icon>         
            <v-toolbar-title  class="headline text-uppercase">
                <span>FUNDABIEM RETALHULEU</span>
            </v-toolbar-title>
            <v-spacer></v-spacer>
            
            <v-btn class="mx-2" title="SALIR DEL SISTEMA" fab color="indigo">
                <v-icon>fas fa-user-times</v-icon>
            </v-btn>
        </v-app-bar>        

        <v-navigation-drawer app clipped
        :mini-variant.sync="mini"
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
          :key="i"
        >
          <v-list-item-icon>
            <v-icon v-text="item.icon"></v-icon>
          </v-list-item-icon>
          <v-list-item-content>
            <v-list-item-title v-text="item.text"></v-list-item-title>
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
          { text: 'Registros Medicos' , icon: 'far fa-address-card'},
          { text: 'Estudio Socioeconomico' , icon: 'far fa-address-card'},
          { text: 'Hoja Evolución Técnica ' , icon: 'far fa-address-card'},
          { text: 'Hoja de Estadísticas Diarias' , icon: 'far fa-address-card'},
      ]
    }),

});
</script>

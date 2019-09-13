<template>
  <v-app>
    <toolbarhp/>
    <footerhp/>
    <router-view/>
  </v-app>
</template>

<script lang="ts">
import { mapGetters } from 'vuex'
//import { Component, Vue } from 'vue-property-decorator'

import Vue from 'vue';
import toolbarhp from './components/PaginaInicio/toolbarhp.vue';
import HomePage from './components/PaginaInicio/HomePage.vue';
import footerhp from './components/PaginaInicio/footerhp.vue';
import HomePageRM from './components/PaginaRegistroMedico/HomePageRM.vue';

export default({
  name: 'App',
  data: () => ({
    //
  }),
    components: {
      toolbarhp,
      HomePage,
      footerhp,
      HomePageRM
  },
  computed: {
    ...mapGetters('oidcStore', [
                'oidcIsAuthenticated'
            ])
  }
});
</script>

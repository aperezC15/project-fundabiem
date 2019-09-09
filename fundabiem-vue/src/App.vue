<template>
  <v-app>
    <toolbarhp/>
    <HomePage/>
  </v-app>
</template>

<script lang="ts">
//import Vue from 'vue';
import toolbarhp from './components/PaginaInicio/toolbarhp.vue'
import HomePage from './components/PaginaInicio/HomePage.vue'
export default({
  name: 'App',
  data: () => ({
    //
  }),
    components: {
      toolbarhp,
      HomePage,
  },
});
</script>

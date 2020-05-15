<template>
  <v-container grid-list-lg>
    <homereporte />
  </v-container>
</template>

<script>
import ReportePrincipal from "../../components/Reportes/ReportePrincipal.vue";

export default {
  components: {
    homereporte: ReportePrincipal
  },
  data() {
    return {};
  },
  methods: {}
};
</script>
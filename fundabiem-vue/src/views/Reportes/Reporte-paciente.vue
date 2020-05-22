<template>
  <v-container grid-list-lg>
    <pacientereporte />
  </v-container>
</template>

<script>
import ReportePaciente from "../../components/Reportes/Reporte-paciente.vue";

export default {
  components: {
    pacientereporte: ReportePaciente
  },
  data() {
    return {};
  },
  methods: {}
};
</script>

<template>
  <v-row>
    <v-dialog
      v-model="dialogRegistroMedicoDetalle"
      persistent
      fullscreen
      hide-overlay
      transition="dialog-bottom-transition"
    >
      <v-card>
        <v-toolbar dark color="#2c2e3f">
          <span class="headline text-uppercase">Detalle del registro médico</span>
          <div class="flex-grow-1"></div>
        </v-toolbar>

        <v-card-text>
          <v-card>
            <v-col md="12">
              <h2 class="text-uppercase text-center font-weight-bold mt-3">Datos personales</h2>
              <datos-persona
                :historialClinico="historialClinico"
                :familiar="1"
                :paciente="paciente"
                :readonly="true"
              />

              <alert-error-global
                v-show="showAlertDetalle"
                message="Ocurrió un error al obtener datos del paciente. Intente de nuevo"
              />
            </v-col>

            <h2 class="text-uppercase text-center font-weight-bold">Completar el registro</h2>
            <v-form ref="formRef" v-model="formValid">
              <v-row class="pa-3">
                <v-col cols="12" sm="6">
                  <v-textarea
                    :rules="rulesInput"
                    v-model="diagnosticoFinal"
                    solo
                    label="Diagnóstico Final"
                    auto-grow
                  ></v-textarea>
                </v-col>
                <v-col cols="12" sm="6">
                  <v-textarea
                    :rules="rulesInput"
                    v-model="recomendaciones"
                    solo
                    label="Recomendaciones"
                    auto-grow
                  ></v-textarea>
                </v-col>
                <v-col cols="12" sm="6">
                  <v-btn large color="info" block @click="programarCitas">Programar citas</v-btn>
                </v-col>
              </v-row>
            </v-form>

            <v-card-actions class="pa-3">
              <v-btn :disabled="!formValid" color="success" @click="completarRegistro">Continuar</v-btn>
              <v-btn color="error" @click="closeModalDetalle" class="mx-4">CERRAR</v-btn>
            </v-card-actions>
          </v-card>
        </v-card-text>
      </v-card>
    </v-dialog>

    <new-cites-component
      :terapias="terapias" 
      :showEstados="false"
      :closeModalCitesC="closeModalCitesC" @closeModalCites="closeModalCites" />
  </v-row>
</template>
    
<script>
import DatosPersona from "../datos-personas/DatosPersonas.vue";
import AlertErrorGlobal from "../alertas/alertErrorGlobal.vue";
import NewCitesComponent from "../../components/citas/NewCites.vue";
const namespace = "oidcStore/";

export default {
  components: {
    DatosPersona,
    AlertErrorGlobal,
    NewCitesComponent
  },
  props: {
    dialogRegistroMedicoDetalle: Boolean,
    historialClinico: Object,
    paciente: Object,
    showAlertDetalle: Boolean,
  },
  data() {
    return {
      formValid: false,
      rulesInput: [v => !!v || "El campo es obligatorio"],
      diagnosticoFinal: "",
      recomendaciones: "",
      formValid: false,
      closeModalCitesC: false,
      user: {},
      terapias: [],
    };
  },
  methods: {
    closeModalDetalle() {
      this.$emit("closeModalDetalle");
      this.$refs.formRef.reset();
    },
    completarRegistro() {
      const data = {
        diagnosticoFinal: this.diagnosticoFinal,
        recomendaciones: this.recomendaciones
      };

      this.$emit("completarRegistro", data);
      this.$refs.formRef.reset();
    },
    async programarCitas() {
      this.closeModalCitesC = true;
      const response = await this.$store.dispatch('getTerapias')
      if(response.status === 200) {
        const data = response.data.map( ({idTerapia, descripcion}) => ({idTerapia, descripcion}) )
        this.terapias = data
      }
    },
    closeModalCites() {
      this.closeModalCitesC = false;
    },
    getSub() {
      const user = this.$store.getters[namespace + "oidcUser"];
      return user;
    }
  },
  mounted() {
    this.user = this.getSub();
    console.log(this.user)
  }
};
</script>


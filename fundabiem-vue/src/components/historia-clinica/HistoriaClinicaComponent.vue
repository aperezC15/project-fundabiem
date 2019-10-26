
<template>
  <v-row>
    <v-dialog
      v-model="dialogHistorialMedico"
      persistent
      fullscreen
      hide-overlay
      transition="dialog-bottom-transition"
    >
      <v-card>
        <v-toolbar dark color="#2c2e3f">
          <span class="headline text-uppercase">Registro Médico</span>
          <div class="flex-grow-1"></div>
        </v-toolbar>

        <v-card-text>
                <v-stepper v-model="e1">
            <v-stepper-header>
              <v-stepper-step :complete="e1 > 1" step="1">Datos del paciente</v-stepper-step>

              <v-divider></v-divider>
              

              <v-stepper-step :complete="e1 > 2" step="2">Datos de ANAMNESIS</v-stepper-step>


              <v-divider></v-divider>

            </v-stepper-header>

            <v-stepper-items>
              <v-stepper-content step="1">
                <v-card class="mb-12" >
                    <buscador @buscador="buscador" @cleanData="cleanData" />
                    <v-container v-show="searchPatient">
                        <datos-persona :familiar="1" :historialClinico="historialClinico" :paciente="paciente" />
                    </v-container>

                </v-card>

                  <v-btn color="primary ma-2" @click="e1 = 2" >Continuar</v-btn>
                  <v-btn color="error"  @click="closeModalAnamnesis">Cerrar</v-btn>
            
              </v-stepper-content>
 
              <v-stepper-content step="2">
                <v-card class="mb-12" >
                   <h2 class="text-uppercase text-center font-weight-bold">ANAMNESIS</h2>
                    <anamnesis @newHistory="newHistory" @goBack="goBack" @closeModalAnamnesis="closeModalAnamnesis" />
                </v-card>

              </v-stepper-content>

      
            </v-stepper-items>

          </v-stepper>
           
        </v-card-text>
      </v-card>
    </v-dialog>
  </v-row>
</template>
    
<script>
import Buscador from '../buscador/Buscador.vue'
import DatosPersona from "../datos-personas/DatosPersonas.vue";
import Anamnesis from '../historia-clinica/AnamnesisComponent.vue'


let pacienteObject = {
  primerNombre: "Juan",
  segundoNombre: "Pablo",
  primerApellido: "Villa",
  segundoApellido: "Gomez",
  sexo: "Masculino",
  fechaNacimiento: new Date().toISOString().substr(0, 10),
  menu2: false,
  grupoEtnico: "Ladino",
  escolaridad: "Primaria",
  religion: "Cristiano",
  dpi: "82099393"
};


export default {
  components: {
    Buscador,
    DatosPersona,
    Anamnesis
  },
  props: {
    dialogHistorialMedico: Boolean
  },
  data() {
    return {
      e1: 1,
      paciente: {
        ...pacienteObject
      },
      idPaciente: "1",
      searchPatient: false,
       historialClinico : { nombre: "" }
    };
  },
  methods: {
    closeModalAnamnesis() {
      this.getCopyData();
      this.$emit("closeModalAnamnesis");
       this.e1 = 1
    },
    saveRehabilitacion() {
      this.$emit("saveRehabilitacion", data);
    },
    goBack() {
      this.e1 = 1
    },
    newHistory(data) {

      const newData = {
        idPaciente: this.idPaciente,
        ...data
      }

      this.$emit('newHistory',newData)
    },
    buscador(search) {
      console.log(search)
      this.searchPatient = true
    },
    cleanData() {
      this.searchPatient = false
    },
    getCopyData() {
      this.paciente = { ...pacienteObject };
    }
  }
};
</script>


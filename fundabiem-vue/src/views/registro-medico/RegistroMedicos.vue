<template>
  <v-container grid-list-lg >
    <v-layout row wrap>
      <v-flex xs12>

                <v-layout text-center wrap>
                <v-flex>
                    <h1  class="text-xs-center text-uppercase"> Registros Médicos</h1>
                </v-flex>
            </v-layout>
        <v-card>
          <v-toolbar flat dark color="#2c2e3f">
            <v-toolbar-title>REGISTROS</v-toolbar-title>
            <v-divider class="mx-4" vertical></v-divider>
            <div class="flex-grow-1"></div>

            <v-text-field
              v-model="search"
              label="BUSCAR "
              append-icon="search"
              single-line
              hide-details
            ></v-text-field>
            <v-btn
              color="indigo"
              fab
              title="NUEVO REGISTRO MÉDICO"
              class="mx-2"
              @click="openDialogRegistroMedico"
            >
              <v-icon>add</v-icon>
            </v-btn>
          </v-toolbar>

          <v-data-table :headers="headers" :items="dataRegistersMedicals" :search="search" class="elevation-1">
         
            <template v-slot:no-data v-if="dataRegistersMedicals.length === 0">
              <v-alert
                class="text-xs-center"
                :value="true"
                color="warning"
                icon="warning"
              >No existen registros en la tabla</v-alert>
            </template>

            <template v-slot:item.action="{item}">
              <v-btn
                title="EDITAR REGISTRO DE ESTUDIO SOCIOECONOMICO"
                fab
                color="success"
                dark
                @click="editItem(item)"
              >
                <v-icon>edit</v-icon>
              </v-btn>
            </template>
            <template v-slot:no-results>
              <v-alert type="error">EL REGISTRO "{{search}}" NO SE ENCUENTRA EN LA BASE DE DATOS</v-alert>
            </template>
          </v-data-table>
        </v-card>
      </v-flex>
    </v-layout>

    <registro-medico
      :dialogRegistroMedico="dialogRegistroMedico"
      @closeModalRehabilitation="closeModalRehabilitation"
      @saveRehabilitacion="saveRehabilitacion"
    />

    <v-dialog v-model="loading" width="300px">
      <v-card height="100px" class="d-flex justify-center align-center">
      <v-card-text>
        <span class="title  font-weight-bold">Cargando...</span>
        <div class="text-center">
            <v-progress-linear
              height="8"
          indeterminate
          color="green"
        ></v-progress-linear>
        </div>
      </v-card-text>
        </v-card> 
    </v-dialog>

  </v-container>
</template>

<script>
import RegistroMedico from '../../components/registro-medico/RegistroMedicoComponent.vue'
export default {
  components: { 
    RegistroMedico,
  },
  data() {
    return {
      search: "",
      headers: [
        { text: "historial Clinico", value: "historialClinico" },
        { text: "Nombre completo", align: "left", sortable: false, value: "nombreCompleto" },
        { text: "DPI", value: "dpi" },
        { text: "Grupo Étnico", value: "grupoEtnico" },
        { text: "Fecha Admision", value: "fechaAdmision" },
        { text: "Acciones", value: "action" }
      ],
      dataRegistersMedicals: [ ],
      dialogRegistroMedico: false,
      dialogRehabilitacion: false,
      loading: false,

    }
  },
  methods: {
    openDialogRegistroMedico() {
      this.dialogRegistroMedico = true
      this.$store.dispatch('getPaises')
    },
    async saveRehabilitacion(data) {

      this.dialogRegistroMedico = false
      this.loading = true

      const response = await this.$store.dispatch('newMedicalRegister', data)

      this.loading = false
      if(response.status === 200) {
        const title = "Nuevo registro médico creado con éxito!"
        const message = "Nuevo registro médico exitosamente"
        this.showAlert(title, message, "success")
      } else {
        const title = "Nuevo registro médico creado sin éxito!"
        const message = "Nuevo registro médico no se ha creado"
        this.showAlert(title, message, "error")
      }
    },

    showAlert(title, message, type) {
      this.$swal.fire(
        title,
        message,
        type
      );
    },
    closeModalRehabilitation() {
      this.dialogRegistroMedico= false
       this.$store.commit('clearStore')
    },
    async getMedicalsRegisters() {
      this.loading = true
      const response = await this.$store.dispatch('getMedicalsRegistros')
      this.loading = false
      if(response.status === 200 && response.data.length >= 0) {
        response.data.map( register => {
              const { fechaAdmision } = register
             const { estaActivo, historialClinico, idPaciente } = register.paciente
             const { primerApellido, primerNombre, segundoApellido, segundoNombre, grupoEtnico, dpi, } = register.paciente.persona

             const nombreCompleto = `${primerNombre} ${segundoNombre} ${primerApellido} ${segundoApellido}`

              this.dataRegistersMedicals.push({ estaActivo, historialClinico, idPaciente, fechaAdmision,
                nombreCompleto, grupoEtnico, dpi,
              })
           })
      }
    }
  },
  mounted(){
    this.getMedicalsRegisters()
  }
};
</script>
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
                title="COMPLETAR EL REGISTRO MÉDICO"
                fab
                color="success"
                dark
                @click="openDetailRegister(item)"
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

    <registro-medico-detalle 
      :dialogRegistroMedicoDetalle="dialogRegistroMedicoDetalle"
      :paciente="paciente"
      :historialClinico="historialClinico"
      :showAlertDetalle="showAlertDetalle"
      @closeModalDetalle="closeModalDetalle"
      @completarRegistro="completarRegistro"
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
import RegistroMedicoDetalle from '../../components/registro-medico/RegistroMedicoDetalle.vue'

export default {
  components: { 
    RegistroMedico,
    RegistroMedicoDetalle
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
      dialogRegistroMedicoDetalle: false,
      historialClinico: {},
      paciente: {},
      idRegistroMedico: "",
      showAlertDetalle: false
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
        this.getMedicalsRegisters()
        const title = "Registro médico creado exitosamente!"
        const message = "Registro médico creado exitosamente"
        this.showAlert(title, message, "success")
      } else {
        const title = "El registro medico no fue registrado"
        const message = "Intente de nuevo"
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

    async completarRegistro(data) {

      this.dialogRegistroMedicoDetalle = false
      this.loading = true

      const newData = {
        idRegistroMedico: this.idRegistroMedico,
        ...data
      }

      const response = await this.$store.dispatch('completeRegister', newData)

      this.loading = false
      if(response.status === 200) {
        this.getMedicalsRegisters()
        const title = "Se completo el registro médico con éxito!"
        const message = "Se completo el registro médico  exitosamente"
        this.showAlert(title, message, "success")
      } else {
        const title = "No se completo el registro médico!"
        const message = "No se ha completado el registro médico"
        this.showAlert(title, message, "error")
      }
    },

    async openDetailRegister(item) {
      this.showAlertDetalle = false
      this.idRegistroMedico = ""
      const idRegistro = item.idRegistroMedico
      this.idRegistroMedico = idRegistro

      const response = await this.$store.dispatch('getOneMedicalsRegisters', {idRegistro})
      this.dialogRegistroMedicoDetalle = true

      if(response.status === 200) {

        const { persona, historialClinico } = response.data[0].paciente

        this.paciente = {
          ...persona,
          sexo: (persona.sexo) ? 1 : 2
        }

        this.historialClinico = {
          nombre: historialClinico
        }

      } else {
        this.showAlertDetalle = true
      }

    }, 
    closeModalDetalle() {
      this.dialogRegistroMedicoDetalle = false
    },
    async getMedicalsRegisters() {
      this.loading = true
      const response = await this.$store.dispatch('getMedicalsRegistros')

      console.log(response)

      this.loading = false
      if(response.status === 200 && response.data.length >= 0) {
        console.log('data ==> ',response.data)
        response.data.map( register => {
              const { fechaAdmision, idRegistroMedico } = register
             const { estaActivo, historialClinico, idPaciente } = register.paciente
             const { primerApellido, primerNombre, segundoApellido, segundoNombre, grupoEtnico, dpi, } = register.paciente.persona

             const nombreCompleto = `${primerNombre} ${segundoNombre} ${primerApellido} ${segundoApellido}`

              this.dataRegistersMedicals.push({ estaActivo, historialClinico, idPaciente, fechaAdmision,
                nombreCompleto, grupoEtnico, dpi, idRegistroMedico
              })

              //modificar aca
              
           })
      }
    }
  },
  mounted(){
    this.getMedicalsRegisters()
  }
};
</script>
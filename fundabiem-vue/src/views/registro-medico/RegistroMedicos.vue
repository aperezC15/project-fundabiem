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

          <v-data-table :headers="headers" :items="cicloRehabilitacionCIF" :search="search" class="elevation-1">
            <template v-slot:no-data v-if="cicloRehabilitacionCIF.length === 0">
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

    <edit-ciclo-rehabilitacion 
      :showEditCiclo="showEditCiclo"
      :cicloEdit="cicloEdit"
      @closeEditModalRehabilitation="closeEditModalRehabilitation"
      @saveEditRehabilitacion="saveEditRehabilitacion"
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
import EditCicloRehabilitacion from '../../components/ciclo-rehabilitacion/EditCicloRehabilitacion.vue'
export default {
  components: { 
    RegistroMedico,
    EditCicloRehabilitacion
  },
  data() {
    return {
      search: "",
      headers: [
        { text: "Nombre completo", align: "left", sortable: false, value: "nombre" },
        { text: "Edad", value: "edad" },
        { text: "Sexo", value: "sexo" },
        { text: "Origen", value: "origen" },
        { text: "Diagnóstico", value: "diagnostico" },
        { text: "fecha", value: "fecha" },
        { text: "Acciones", value: "action" }
      ],
      cicloRehabilitacionCIF: [
        {id: 1, nombre: "Juan Gómez", edad: 62, sexo: "masculino", origen: "Guatemala", diagnostico: "Su diagnostico", fecha: "2019-08-12" },
        { id: 2, nombre: "Benito Juarez", edad: 32, sexo: "masculino", origen: "Guatemala", diagnostico: "El diagnostico", fecha: "2016-02-10" },
      ],
      dialogRegistroMedico: false,
      dialogRehabilitacion: false,
      loading: false,
      cicloEdit: {},
      showEditCiclo: false

    }
  },
  methods: {
    openDialogRegistroMedico() {
      this.dialogRegistroMedico = true
    },
    saveRehabilitacion(data) {

       const { id, nombre,  edad , sexo , origen, diagnostico, fecha } = data 

       this.cicloRehabilitacionCIF.push({id, nombre, edad, sexo, origen, diagnostico, fecha})
       this.dialogRehabilitacion = false

      this.loading = true

       setTimeout( () => {
         this.loading = false
         this.$swal.fire(
          'Nuevo ciclo de rehabilitación creado con éxito!',
          'Nuevo ciclo creado exitosamente',
          'success'
         );
       },2000)


      // console.log(data);
    },
    closeModalRehabilitation() {
      this.dialogRehabilitacion= false
    },
    editItem(item) {
      this.showEditCiclo = true

       this.cicloEdit = this.cicloRehabilitacionCIF.find( ciclo => ciclo.id === item.id)

    },
    saveEditRehabilitacion(data) {
          const { id, nombre,  edad , sexo , origen, diagnostico, fecha } = data 

          const editCiclo = {id, nombre, edad, sexo, origen, diagnostico, fecha}

        this.cicloRehabilitacionCIF = this.cicloRehabilitacionCIF.map( ciclo => ciclo.id === data.id ? editCiclo : ciclo )

       this.showEditCiclo = false

      this.loading = true

       setTimeout( () => {
         this.loading = false
         this.$swal.fire(
          'Ciclo de rehabilitación editado con éxito!',
          'Ciclo editado exitosamente',
          'success'
         );
       },2000)
    },
    closeEditModalRehabilitation() {
      this.showEditCiclo = false
    }
  }
};
</script>
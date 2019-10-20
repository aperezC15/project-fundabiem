
<template>
  <v-row>
    <v-dialog
      v-model="dialogRegistroMedico"
      persistent
      fullscreen
      hide-overlay
      transition="dialog-bottom-transition"
    >
      <v-card>
        <v-toolbar dark color="#2c2e3f">
          <span class="headline text-uppercase">Nuevo ciclo de rehabilitación</span>
          <div class="flex-grow-1"></div>
          <v-btn color="indigo" rounded @click="closeModalRehabilitation" class="mx-4">CERRAR</v-btn>
          <v-btn
            color="indigo"
            rounded
            :disabled="!formValid"
            @click="saveRehabilitacion"
          >GUARDAR REGISTRO</v-btn>
        </v-toolbar>

        <v-card-text>
          <v-stepper v-model="e1">
            <v-stepper-header>
              <v-stepper-step :complete="e1 > 1" step="1">Datos del paciente</v-stepper-step>

              <v-divider></v-divider>
              

              <v-stepper-step :complete="e1 > 2" step="2">Datos de los familiares</v-stepper-step>

              <v-divider></v-divider>

              <v-stepper-step :complete="e1 > 3" step="3">Persona Encargada</v-stepper-step>

              <v-divider></v-divider>

              <v-stepper-step step="4">Diagnóstico final</v-stepper-step>
            </v-stepper-header>

            <v-stepper-items>
              <v-stepper-content step="1">
                <v-card class="mb-12" >
                    <v-col  md="12">
                      <h2 class="text-uppercase text-center font-weight-bold">Datos personales</h2>
                      <datos-persona :familiar="false"  :datosPersonas="datosPersonas" />

                      <h2 class="text-uppercase text-center font-weight-bold">Datos de residencia</h2>

                      <datos-residencia :datosResidencia="datosResidencia" />
                    </v-col>

                </v-card>

                  <v-btn color="primary" @click="e1 = 2">Continuar</v-btn>
            
              </v-stepper-content>

              <v-stepper-content step="2">
                <v-card class="mb-12" >
                   <h2 class="text-uppercase text-center font-weight-bold">Datos de los familiares</h2>
                      <datos-persona  @agregarAlListado="agregarAlListado" :familiar="true"  :datosPersonas="datosDeFamiliares" />
                      <data-tables :btnEliminar="true" @eliminarDelListado="eliminarDelListado" title="Listado de familiares" :headers="headers" :data="data"/>
                </v-card>

                <v-btn color="primary" @click="continueStep3">Continuar</v-btn>

                <v-btn text  @click="e1 = 1">Regresar</v-btn>
              </v-stepper-content>

              <v-stepper-content step="3">
                <v-card class="mb-12" >
                   <v-col cols="12" sm="4" md="12">
                     <h2 class="text-uppercase text-center font-weight-bold">Datos de la persona encargada</h2>
                    <v-select v-model="familiares" :items="arrayFamiliares" :rules="rulesInput" item-value="id" item-text="valor" label="Seleccione a persona encargado" hint="El campo es requerido"
                    ></v-select>
                     <datos-residencia :encargado="true" :datosResidencia="datosResidenciaEncargado" />
                  </v-col>
                </v-card>

                <v-btn color="primary" @click="e1 = 4">Continuar</v-btn>

                <v-btn text  @click="e1 = 2">Regresar</v-btn>
              </v-stepper-content>

              <v-stepper-content step="4">
                <v-card class="mb-12" >
                   <v-col cols="12" sm="4" md="12">
                     
                      <h2 class="text-uppercase text-center font-weight-bold">Datos personales</h2>
                      <datos-persona  :datosPersonas="datosPersonas" />

                      <h2 class="text-uppercase text-center font-weight-bold">Datos de residencia</h2>
                      <datos-residencia :datosResidencia="datosResidencia" />

                      <h2 class="text-uppercase text-center font-weight-bold">Datos de los familiares</h2>
                      <!-- <datos-persona  @agregarAlListado="agregarAlListado" :familiar="true"  :datosPersonas="datosDeFamiliares" /> -->
                      <data-tables class="mt-5"  :btnEliminar="false" title="Listado de familiares" :headers="headers" :data="data"/>

                      <h2 class="text-uppercase text-center font-weight-bold mt-5">Datos de la persona encargada</h2>
                     <datos-residencia :encargado="false" :datosResidencia="datosResidenciaEncargado" />

                  </v-col>
                </v-card>

                <v-btn color="primary" @click="e1 = 1">Guardar</v-btn>

                <v-btn text  @click="e1 = 3">Regresar</v-btn>
              </v-stepper-content>
            </v-stepper-items>

          </v-stepper>
        </v-card-text>
      </v-card>
    </v-dialog>
  </v-row>
</template>
    
<script>

import DatosPersona from  '../datos-personas/DatosPersonas.vue'
import DatosResidencia from  '../datos-personas/DatosResidencia.vue'
import DataTables from '../data-tables/DataTables.vue'

export default {
 components: {
     DatosPersona,
     DatosResidencia,
     DataTables
 },
  props: {
    dialogRegistroMedico: Boolean
  },
  data() {
    return {
      formValid: false,
      mostrarDatosResidencia: true,
      e1: 0,
      datosPersonas: {
        primerNombre : "",
        segundoNombre : "",
        tercerNombre : "",
        primerApellido : "",
        segundoApellido : "",
        edad: "",
        sexo: "",
        date: new Date().toISOString().substr(0, 10),
        menu2: false,
        etnico: "",
        hisClinica: "",
        sexosArray: [
          { id: 1, valor: "Masculino", },
          { id: 2, valor: "Femenino"}
        ],
        grupoEtnico: [
          { id: 1, valor: "Ladino", },
          { id: 2, valor: "Maya"},
          { id: 3, valor: "Garifuna"},
          { id: 4, valor: "Xinca"}
        ],
      },
      datosDeFamiliares: {
        id: "",
        primerNombre : "",
        segundoNombre : "",
        tercerNombre : "",
        primerApellido : "",
        segundoApellido : "",
        sexo: "",
        etnico: "",
        parentescoFamiliar:"",
        sexosArray: [
          { id: 1, valor: "Masculino", },
          { id: 2, valor: "Femenino"}
        ],
        grupoEtnico: [
          { id: 1, valor: "Ladino", },
          { id: 2, valor: "Maya"},
          { id: 3, valor: "Garifuna"},
          { id: 4, valor: "Xinca"}
        ],
      },
      datosResidencia: {
        pais:"",
        departamento:"",
        municipio: "",
        direccion : "",
        tipo: "",
        paisesArray: [
          { id: 1, valor: "Guatemala", },
        ],
        departametosArray: [
          { id: 1, valor: "Retalhuleu", },
          { id: 2, valor: "Mazatenango"},
          { id: 3, valor: "Escuintla"},
          { id: 4, valor: "Coatepeque"}
        ],
        municipioArray: [
          { id: 1, valor: "San Felipe", },
          { id: 2, valor: "San sebastián"},
          { id: 3, valor: "Retalhulue"},
          { id: 4, valor: "Champerico"}
        ],
        tipoDireccion:[
          { id: 1, valor: "Residencia habitual", },
          { id: 2, valor: "Domicilio"},
        ],
      },
      datosResidenciaEncargado :{
         pais:"",
        departamento:"",
        municipio: "",
        direccion : "",
        tipo: "",
        telefono: "",
        paisesArray: [
          { id: 1, valor: "Guatemala", },
        ],
        departametosArray: [
          { id: 1, valor: "Retalhuleu", },
          { id: 2, valor: "Mazatenango"},
          { id: 3, valor: "Escuintla"},
          { id: 4, valor: "Coatepeque"}
        ],
        municipioArray: [
          { id: 1, valor: "San Felipe", },
          { id: 2, valor: "San sebastián"},
          { id: 3, valor: "Retalhulue"},
          { id: 4, valor: "Champerico"}
        ],
        tipoDireccion:[
          { id: 1, valor: "Residencia habitual", },
          { id: 2, valor: "Domicilio"},
        ],
      },
      headers: [
        { text: "Primer Nombre", align: "left", sortable: false, value: "primerNombre" },
        { text: "Segundo Nombre", align: "left", sortable: false, value: "segundoNombre" },
        { text: "Tercer Nombre", align: "left", sortable: false, value: "tercerNombre" },
        { text: "Primer Apellido", align: "left", sortable: false, value: "primerApellido" },
        { text: "Segundo Apellido", align: "left", sortable: false, value: "segundoApellido" },
         { text: "Edad", value: "edad" },
         { text: "Parentesco", value: "parentescoFamiliar" },
         { text: "Acciones", value: "action" }
      ],
      data: [],
      datosFinalPersonal: {},
      datosFinalFamiliares: [],
      arrayFamiliares: [],
      familiares: "",
      rulesInput: [
          v => !! v || "El campo es obligatorio"
      ],
    }
  },
  methods: {
    closeModalRehabilitation() {
      this.$emit("closeModalRehabilitation");

      this.$refs.formRef.reset();
    },
    saveRehabilitacion() {
      const data = {
        id: Math.random()
          .toString(36)
          .substr(2, 9),
        nombre: this.nombreCompleto,
        edad: this.edad,
        sexo: this.sexo,
        origen: this.origen,
        diagnostico: this.diagnostico,
        cie: this.cie,
        otros: this.otros,
        fecha: this.date,
        estructurasCorporales: this.estructurasCorporales,
        actividad: this.actividad,
        participacion: this.participacion
      };

      if (this.$refs.formRef.validate()) {
        this.$emit("saveRehabilitacion", data);
      }

      this.$refs.formRef.reset();
    },
    // eventos en datos de familiares
    agregarAlListado(datosFamiliares) {

      console.log(datosFamiliares)
      
      const { id, primerNombre, segundoNombre, tercerNombre, primerApellido, segundoApellido, edad, sexo, etnico, parentescoFamiliar } = datosFamiliares

      const dataAgregar = {id, primerNombre, segundoNombre, tercerNombre, primerApellido, segundoApellido, edad, sexo, etnico, parentescoFamiliar }

      this.data.push(dataAgregar)
    },
    eliminarDelListado(id) {
      this.data = this.data.filter( item => item.id !== id)
    },
    // continue step 3
    continueStep3() {
      this.data.map( item => {
          this.arrayFamiliares.push({
          id: item.id,
          valor: item.parentescoFamiliar
        })
      })
  
      this.e1 = 3
    }
  },

};
</script>


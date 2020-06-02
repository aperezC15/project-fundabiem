<template>
  <div class="text-center">
    <v-card>
      <v-toolbar>
        <v-tooltip bottom color="#BDBDBD">
          <template v-slot:activator="{ on }">
            <v-btn v-on="on" color="#757575" fab dark :to="{name: 'ReportesHome'}">
              <v-icon>fas fa-arrow-alt-circle-left</v-icon>
            </v-btn>
          </template>
          <span>Regresar</span>
        </v-tooltip>
        <v-flex>
          <h1 class="text-xs-center text-uppercase">Nuevo Reporte de Pacientes</h1>
        </v-flex>
      </v-toolbar>

      <v-alert border="bottom" type="info">Selecciona todos los parámetros</v-alert>

      <v-row justify="space-around">
        <v-col class="ml-2" cols="5" sm="5">
          <v-autocomplete
            color="blue-grey darken-1"
            v-model="datosResidencia.pais"
            :items="getPaises"
            item-value="idPais"
            item-text="nombre"
            label="País"
            prepend-inner-icon="location_on"
            no-data-text="No hay países disponibles"
            rounded
            outlined
            @change="getDepartamento"
          ></v-autocomplete>
        </v-col>
        <v-col class="ml-2" cols="5" sm="5">
          <v-autocomplete
            color="blue-grey darken-1"
            :disabled="!disabledDepartamento"
            v-model="datosResidencia.departamento"
            :items="getDepartamentos"
            item-value="idDepartamento"
            item-text="nombre"
            label="Departamento"
            prepend-inner-icon="location_city"
            no-data-text="No hay departamentos disponibles"
            rounded
            outlined
            @change="getMunicipios"
          ></v-autocomplete>
        </v-col>
        <v-col class="ml-2" cols="5" sm="5">
          <v-autocomplete
            :disabled="!disabledMunicipio"
            v-model="datosResidencia.idMunicipio"
            :items="getMunicipios"
            item-value="idMunicipio"
            item-text="nombre"
            label="Municipios"
            prepend-inner-icon="fas fa-building"
            no-data-text="No hay municipios disponibles"
            rounded
            outlined
          ></v-autocomplete>
        </v-col>
        <v-col class="ml-2" cols="5" sm="5">
          <v-select
            color="blue-grey darken-1"
            v-model="idTerpia"
            :items="terapias"
            item-value="idTerapia"
            item-text="descripcion"
            label="Tipo de terapia"
            prepend-inner-icon="fas fa-first-aid"
            no-data-text="No hay terapias ingresadas"
            rounded
            outlined
          ></v-select>
        </v-col>
      </v-row>
      <!--Parte final-->
      <v-divider></v-divider>
      <div class="text-center">
        <v-btn class="mt-5 mb-3" rounded color="light-green darken-2" dark>
          <v-icon left>fas fa-file-alt</v-icon>Generar Reporte
        </v-btn>
      </div>
    </v-card>
    <v-card>
      <v-data-table
        :headers="headers"
        :page.sync="pagina"
        :items-per-page="elementosPagina"
        @page-count="cantidadPagina = $event"
        sort-by="codigo"
        class="elevation-1"
        hide-default-footer
      >
        <template v-slot:top>
          <v-toolbar flat color="white">
            <v-flex>
              <h2 class="text-xs-center text-uppercase">Reporte obtenido</h2>
            </v-flex>
          </v-toolbar>
        </template>
        <template v-slot:no-data>
          <h2>No existen coincidencias</h2>
        </template>
        <template v-slot:no-results>
          <h2>No se encontraron coincidencias</h2>
        </template>
      </v-data-table>
      <div class="text-center pt-2">
        <v-pagination v-model="pagina" :length="cantidadPagina"></v-pagination>
      </div>
    </v-card>
  </div>
</template>

<script>
import { mapGetters } from "vuex";
let datosResidencia = {
  pais: "",
  departamento: "",
  idMunicipio: ""
};

export default {
  props: { terapias: Array },
  computed: {
    ...mapGetters(["getPaises", "getDepartamentos", "getMunicipios"])
  },
  data() {
    return {
      date: null,
      date2: null,
      menu: false,
      menu2: false,
      pagina: 1,
      cantidadPagina: 0,
      elementosPagina: 10,
      datosResidencia: { ...datosResidencia },
      idTerpia: "",
      pais: "",
      departamento: "",
      disabledDepartamento: false,
      disabledMunicipio: false,
      citas: ["Atendida", "En espera", "Cancelada"],

      headers: [
        { text: "Paciente", value: "name" },
        { text: "Fecha de Nacimiento", value: "fechaNc", sortable: false },
        { text: "No. de DPI", value: "dpi", sortable: false },
        { text: "Municipio", value: "municipio", sortable: false }
      ]
    };
  },
  created() {
    this.obtenerTerapias();
  },

  methods: {
    obtenerTerapias() {
      const data = {
        idTerpia: this.idTerpia,
        terapias: this.terapias
      };
    },
    getDepartamento() {
      this.$store.dispatch("getDepartamento", this.datosResidencia.pais);
      this.disabledDepartamento = true;
    },
    getMunicipio() {
      this.$store.dispatch("getMunicipio", this.datosResidencia.departamento);
      this.disabledMunicipio = true;
    }
  }
};
</script>
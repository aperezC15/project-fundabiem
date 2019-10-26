<template>
  <v-container>
    <v-card class="pa-4">
      <v-form v-model="formValid" ref="formBusqueda">
        <v-row>
          <v-col cols="12" md="3">
            <v-select
              v-model="buscarPor"
              :items="opcionesBuscar"
              item-value="id"
              item-text="valor"
              label="Seleccione búsqueda por"
              :rules="rulesInput"
            ></v-select>
          </v-col>
          <v-col cols="12" md="5">
            <v-text-field
              v-model="valorDeBusqueda"
              label="Valor de busqueda"
              hint="El campo es requerido"
              :rules="rulesInput"
            ></v-text-field>
          </v-col>
          <v-col cols="12" md="2">
            <v-btn large block color="primary" @click="buscador">Buscar</v-btn>
          </v-col>
          <v-col cols="12" md="2">
            <v-btn large block color="warning" @click="cleanData">Limpiar</v-btn>
          </v-col>
        </v-row>
      </v-form>
    </v-card>
  </v-container>
</template>

<script>
export default {
  data() {
    return {
      buscarPor: "",
      valorDeBusqueda: "",
      opcionesBuscar: [
        { id: 1, valor: "Historia clínica" },
        { id: 2, valor: "DPI" },
        { id: 3, valor: "Nombre" }
      ],
      rulesInput: [v => !!v || "El campo es requerido"],
      formValid: false
    };
  },
  methods: {
    buscador() {

      const buscar = {
        buscarPor: this.buscarPor,
        valorDeBusqueda: this.valorDeBusqueda
      }

      this.$emit("buscador", buscar)
      this.$refs.formBusqueda.reset()
    },
    cleanData() {
      this.$emit('cleanData')
      this.$refs.formBusqueda.reset()
    }
  },
};
</script>
<template>
  <v-form v-model="formDatosResidencia" >
    <v-row>
      <v-col cols="12" sm="4">
          <v-autocomplete v-model="datosResidencia.pais" :rules="rulesInput" :items="datosResidencia.paisesArray" item-value="id" item-text="valor" dense label="Seleccione el país"
            ></v-autocomplete>
      </v-col>
      <v-col cols="12" sm="4">
        <v-autocomplete v-model="datosResidencia.departamento" :rules="rulesInput" :items="datosResidencia.departametosArray" item-value="id" item-text="valor" dense label="Seleccione el departamento"
        ></v-autocomplete>
      </v-col>
      <v-col cols="12" sm="4">
      <v-autocomplete v-model="datosResidencia.municipio" :rules="rulesInput" :items="datosResidencia.municipioArray" item-value="id" item-text="valor" dense label="Seleccione el municipio"
        ></v-autocomplete>
      </v-col>
      <v-col cols="12" sm="4" md="8">
        <v-text-field v-model="datosResidencia.direccion" :rules="rulesInput" label="Dirección exacta" hint="El campo es requerido" ></v-text-field>
      </v-col>
      <v-col cols="12" sm="4">
      <v-autocomplete v-model="datosResidencia.tipo" :rules="rulesInput" :items="datosResidencia.tipoDireccion" item-value="id" item-text="valor" dense label="Seleccione el tipo de dirección"
        ></v-autocomplete>
      </v-col>

      <v-col cols="12" sm="4" v-if="encargado">
        <v-text-field type="number" v-model="cantidadTelefono" :rules="rulesInput" label="Número de telefono" hint="El campo es requerido" ></v-text-field>
      </v-col>

      <v-col cols="12" sm="4" v-if="encargado" v-for="telefono in Number(cantidadTelefono)">
        <v-text-field :v-model="datosResidencia.telefono" :rules="rulesInput" label="Número de telefono" hint="El campo es requerido" ></v-text-field>
      </v-col>
   
    </v-row>
  </v-form> 
</template>

<script>
export default {
  props: {
    datosResidencia: Object,
    encargado:Boolean
  },
  data() {
    return {
        rulesInput: [
          v => !! v || "El campo es obligatorio"
        ],
        formDatosResidencia: true,
        cantidadTelefono: 0,
    };
  },
  methods: {
    continueE1() {
      this.$emit('continueE1')
    }
  },
};
</script>
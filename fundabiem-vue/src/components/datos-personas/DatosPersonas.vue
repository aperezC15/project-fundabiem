<template>
    <v-form v-model="formDatosPersonales" ref="formPersonas">
  <v-row>
      <v-col cols="12" sm="4" md="3">
        <v-text-field v-model="datosPersonas.primerNombre" :rules="rulesInput" label="1er. Nombre" hint="El campo es requerido" ></v-text-field>
      </v-col>
      <v-col cols="12" sm="4" md="3">
        <v-text-field v-model="datosPersonas.segundoNombre" label="2do. Nombre" hint="El campo es opcional" ></v-text-field>
      </v-col>
      <v-col cols="12" sm="4" md="3">
        <v-text-field v-model="datosPersonas.tercerNombre" label="3er Nombre" hint="El campo es opcional" ></v-text-field>
      </v-col>
      <v-col cols="12" sm="4" md="3">
        <v-text-field v-model="datosPersonas.primerApellido" :rules="rulesInput" label="1er Apellido" hint="El campo es requerido" ></v-text-field>
      </v-col>
      <v-col cols="12" sm="4" md="3">
        <v-text-field v-model="datosPersonas.segundoApellido"  label="2do. Apellido" hint="El campo es opcional" ></v-text-field>
      </v-col>
      <v-col cols="12" sm="4" md="3" v-if="!familiar">
        <v-text-field v-model="datosPersonas.hisClinica" :rules="rulesInput" label="His. Clínica" hint="El campo es requerido" ></v-text-field>
      </v-col>
      <v-col cols="12" sm="4" md="3">
        <v-text-field v-model="datosPersonas.edad" :rules="rulesInput" type="number" label="Edad" hint="El campo es requerido"
        ></v-text-field>
      </v-col>
      <v-col cols="12" sm="4" md="3">
        <v-select v-model="datosPersonas.sexo" :items="datosPersonas.sexosArray" :rules="rulesInput" item-value="id" item-text="valor" label="Sexo" hint="El campo es requerido"
        ></v-select>
      </v-col>
      <v-col cols="12" sm="4" md="3">
        <v-menu  v-if="!familiar" v-model="datosPersonas.menu2" :close-on-content-click="false" :nudge-right="40" transition="scale-transition" offset-y min-width="290px" >
          <template v-slot:activator="{ on }">
            <v-text-field v-if="!familiar" v-model="datosPersonas.date" :rules="rulesInput"  label="Fecha de nacimiento" prepend-icon="event" readonly v-on="on"></v-text-field>
          </template>
          <v-date-picker v-if="!familiar" v-model="datosPersonas.date" @input="datosPersonas.menu2 = false"></v-date-picker>
        </v-menu>
      </v-col>
      <v-col cols="12" sm="4" md="3">
        <v-select v-model="datosPersonas.etnico" :items="datosPersonas.grupoEtnico" :rules="rulesInput" item-value="id" item-text="valor" label="Grupo Étnico" hint="El campo es requerido"
        ></v-select>
      </v-col>

      <v-col cols="12" sm="4" md="3" v-if="familiar">
        <v-text-field v-model="datosPersonas.parentescoFamiliar" :rules="rulesInput" type="text" label="Parentesco familiar" hint="El campo es requerido"
        ></v-text-field>
      </v-col>

      <v-col cols="12" sm="4" md="3" v-if="familiar">
        <!-- :disabled="!formDatosPersonales" -->
       <v-btn color="primary mt-3"  @click="agregarAlListado">Agregar al listado</v-btn>
      </v-col>

  </v-row>
    </v-form>
</template>

<script>
export default {
  props: {
    datosPersonas: Object,
    familiar: Boolean,
  },
  data() {
    return {
      rulesInput: [
          v => !! v || "El campo es obligatorio"
        ],
    formDatosPersonales: false,
    id: 0,
    };
  },
  methods: {
    agregarAlListado() {
      this.id = this.id + 1
      const data = {
        ...this.datosPersonas,
        id: this.id,
      }

      this.$emit("agregarAlListado", data)
      this.$refs.formPersonas.reset()
    }
  },
};
</script>
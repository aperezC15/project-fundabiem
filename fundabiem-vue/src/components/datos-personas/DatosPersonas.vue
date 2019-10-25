<template>
    <v-form v-model="formDatosPersonales" ref="formPersonas">
  <v-row>
      <v-col cols="12" sm="4" md="3">
        <v-text-field v-model="paciente.primerNombre" :rules="rulesInput" label="1er. Nombre" hint="El campo es requerido" ></v-text-field>
      </v-col>
      <v-col cols="12" sm="4" md="3">
        <v-text-field v-model="paciente.segundoNombre" label="2do. Nombre" hint="El campo es opcional" ></v-text-field>
      </v-col>

      <v-col cols="12" sm="4" md="3">
        <v-text-field v-model="paciente.primerApellido" :rules="rulesInput" label="1er Apellido" hint="El campo es requerido" ></v-text-field>
      </v-col>
      <v-col cols="12" sm="4" md="3">
        <v-text-field v-model="paciente.segundoApellido"  label="2do. Apellido" hint="El campo es opcional" ></v-text-field>
      </v-col>
      <v-col cols="12" sm="4" md="3" v-if="familiar === 1">
        <v-text-field v-model="historialClinico.nombre" :rules="rulesInput" label="His. Clínica" hint="El campo es requerido" ></v-text-field>
      </v-col>
    
      <v-col cols="12" sm="4" md="3">
        <v-select v-model="paciente.sexo" :items="sexosArray" :rules="rulesInput" item-value="id" item-text="valor" label="Sexo" hint="El campo es requerido"
        ></v-select>
      </v-col>

      <v-col cols="12" sm="4" md="3"  v-if=" familiar === 1">
          <v-menu  offset-y ref="paciente.menu2" v-model="paciente.menu2" :close-on-content-click="false"  transition="scale-transition"   min-width="290px" >
              <template v-slot:activator="{ on }">
                <v-text-field v-model="paciente.fechaNacimiento" label="Fecha de nacimiento" :rules="rulesInput" prepend-icon="event" readonly v-on="on" ></v-text-field>
              </template>
              <v-date-picker v-if=" familiar === 1" v-model="paciente.fechaNacimiento" no-title >
              </v-date-picker>
            </v-menu>
          </v-col>

      <v-col cols="12" sm="4" md="3"  v-if="familiar === 2">
          <v-menu  ref="menu" v-model="paciente.menu2" :close-on-content-click="false"   min-width="290px" >
              <template v-slot:activator="{ on }">
                <v-text-field v-model="paciente.fechaNacimiento" label="Fecha de nacimiento" :rules="rulesInput" prepend-icon="event" readonly v-on="on" ></v-text-field>
              </template>
              <v-date-picker v-if="familiar === 2" v-model="paciente.fechaNacimiento" no-title >
              </v-date-picker>
            </v-menu>
          </v-col>


      <v-col cols="12" sm="4" md="3" >
        <v-text-field v-model="paciente.dpi" :rules="rulesInput" type="text" label="DPI" hint="El campo es requerido"
        ></v-text-field>
      </v-col>

      <v-col cols="12" sm="4" md="3">
        <v-select v-model="paciente.grupoEtnico" :items="grupoEtnicos" :rules="rulesInput" item-value="id" item-text="valor" label="Grupo Étnico" hint="El campo es requerido"
        ></v-select>
      </v-col>

      <v-col cols="12" sm="4" md="3" >
        <v-text-field v-model="paciente.escolaridad" :rules="rulesInput" type="text" label="Escolaridad" hint="El campo es requerido"
        ></v-text-field>
      </v-col>

      <v-col cols="12" sm="4" md="3" >
        <v-text-field v-model="paciente.religion" :rules="rulesInput" type="text" label="Religión" hint="El campo es requerido"
        ></v-text-field>
      </v-col>

      <v-col cols="12" sm="4" md="3" v-if="familiar === 2">
        <v-text-field v-model="paciente.parentezco" :rules="rulesInput" type="text" label="Parentesco familiar" hint="El campo es requerido"
        ></v-text-field>
      </v-col>


      <v-col cols="12" sm="4" md="3" v-if="familiar === 2">
        
       <v-btn color="primary mt-3" :disabled="!formDatosPersonales"  @click="agregarAlListado">Agregar al listado</v-btn>
      </v-col>

  </v-row>
    </v-form>
</template>

<script>
export default {
  props: {
    paciente: Object,
    familiar: Number,
    historialClinico: Object
  },
  data() {
    return {
      rulesInput: [
          v => !! v || "El campo es obligatorio"
        ],
    formDatosPersonales: false,
    id: 0,
      grupoEtnicos: [
          { id: 1, valor: "Ladino", },
          { id: 2, valor: "Maya"},
          { id: 3, valor: "Garifuna"},
          { id: 4, valor: "Xinca"}
        ],
      sexosArray: [
          { id: 1, valor: "Masculino", },
          { id: 2, valor: "Femenino"}
      ],
    };
  },
  methods: {
    agregarAlListado() {
      this.id = this.id + 1
      const data = {
        ...this.paciente,
        id: this.id,
      }

      this.$emit("agregarAlListado", data)
      this.$refs.formPersonas.reset()
    }
  },
};
</script>
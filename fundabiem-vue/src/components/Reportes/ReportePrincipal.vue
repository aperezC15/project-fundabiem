<template>
  <div class="text-center">
    <v-card>
      <v-flex>
        <h1 class="text-xs-center text-uppercase">Nuevo Reporte</h1>
      </v-flex>
      <v-alert border="bottom" type="info">Selecciona todos los parámetros</v-alert>
      <v-row justify="space-around">
        <v-avatar color="amber darken-3" size="62">
          <v-icon dark>far fa-calendar-alt</v-icon>
        </v-avatar>
        <v-avatar color="amber darken-3" size="62">
          <v-icon dark>far fa-calendar-alt</v-icon>
        </v-avatar>
      </v-row>
      <v-row justify="space-around">
        <v-col cols="5" sm="5">
          <v-menu
            ref="menu"
            v-model="menu"
            :close-on-content-click="false"
            transition="scale-transition"
            offset-y
            min-width="290px"
          >
            <template v-slot:activator="{ on }">
              <v-text-field
                class="mx-2"
                v-model="date"
                v-on="on"
                color="amber darken-3"
                label="Selecciona Fecha de Inicio"
                outlined
                rounded
              ></v-text-field>
            </template>
            <v-date-picker
              ref="picker"
              v-model="date"
              color="amber darken-3"
              :max="new Date().toISOString().substr(0, 10)"
              @change="save"
              locale="gt"
            ></v-date-picker>
          </v-menu>
        </v-col>
        <v-col cols="5" sm="5">
          <v-menu
            ref="menu2"
            v-model="menu2"
            :close-on-content-click="false"
            transition="scale-transition"
            offset-y
            min-width="290px"
          >
            <template v-slot:activator="{ on }">
              <v-text-field
                v-model="date2"
                class="mx-2"
                v-on="on"
                color="amber darken-3"
                label="Selecciona Fecha Fin"
                outlined
                rounded
              ></v-text-field>
            </template>
            <v-date-picker
              ref="picker2"
              v-model="date2"
              color="amber darken-3"
              :max="new Date().toISOString().substr(0, 10)"
              @change="save2"
              locale="gt"
            ></v-date-picker>
          </v-menu>
        </v-col>
      </v-row>
      <v-row justify="space-around">
        <v-col class="ml-2" cols="5" sm="5">
          <v-select
            color="blue-grey darken-1"
            :items="terapias"
            label="Tipo de terapia"
            prepend-inner-icon="fas fa-first-aid"
            rounded
            outlined
          ></v-select>
        </v-col>
        <v-col class="ml-2" cols="5" sm="5">
          <v-select
            color="blue-grey darken-1"
            :items="citas"
            label="Estado de la Cita"
            prepend-inner-icon="fas fa-clipboard-check"
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
  </div>
</template>

<script>
export default {
  data() {
    return {
      date: null,
      date2: null,
      menu: false,
      menu2: false,
      citas: ["Atendida", "En espera", "Cancelada"],
      terapias: ["Hidroterapia", "Fisoterapia", "Terapia del lenguaje"]
    };
  },
  watch: {
    menu(val) {
      val && setTimeout(() => (this.$refs.picker.activePicker = "YEAR"));
    },
    menu2(val) {
      val && setTimeout(() => (this.$refs.picker2.activePicker = "YEAR"));
    }
  },
  methods: {
    save(date) {
      this.$refs.menu.save(date);
    },
    save2(date2) {
      this.$refs.menu2.save(date2);
    }
  }
};
</script>
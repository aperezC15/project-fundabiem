<template>
  <v-row justify="center">
    <v-dialog
      v-model="showCitesModal"
      fullscreen
      hide-overlay
      transition="dialog-bottom-transition"
    >
      <v-card class="mx-auto">
        <v-toolbar dark color="info">
          <v-toolbar-title>Settings</v-toolbar-title>
          <v-spacer></v-spacer>
          <v-toolbar-items>
            <v-btn dark text @click="closeModal">Cerrar</v-btn>
          </v-toolbar-items>
        </v-toolbar>

        <v-card>
          <v-card-text>
            <alert-error-global
              v-if="errorDB"
              message="Ocurrio un inconveniente intente más tarde!"
            />
            <v-row>
              <v-col cols="12" sm="6" md="4">
                <v-menu
                  v-model="menu1"
                  :close-on-content-click="false"
                  :nudge-right="40"
                  transition="scale-transition"
                  offset-y
                  min-width="290px"
                >
                  <template v-slot:activator="{ on }">
                    <v-text-field
                      v-model="DateType"
                      label="Fecha de la cita"
                      prepend-icon="event"
                      readonly
                      v-on="on"
                    ></v-text-field>
                  </template>
                  <v-date-picker v-model="DateType" @input="menu1 = false"></v-date-picker>
                </v-menu>
              </v-col>
              <v-col cols="12" sm="6" md="4">
                <v-menu
                  v-model="menu2"
                  :close-on-content-click="false"
                  :nudge-right="40"
                  transition="scale-transition"
                  offset-y
                  min-width="290px"
                >
                  <template v-slot:activator="{ on }">
                    <v-text-field
                      v-model="dateStart"
                      label="Fecha de inicio"
                      prepend-icon="event"
                      readonly
                      v-on="on"
                    ></v-text-field>
                  </template>
                  <v-date-picker v-model="dateStart" @input="menu2 = false"></v-date-picker>
                </v-menu>
              </v-col>
              <v-col cols="12" sm="6" md="4">
                <v-menu
                  v-model="menu3"
                  :close-on-content-click="false"
                  :nudge-right="40"
                  transition="scale-transition"
                  offset-y
                  min-width="290px"
                >
                  <template v-slot:activator="{ on }">
                    <v-text-field
                      v-model="dateEnd"
                      label="Fecha final"
                      prepend-icon="event"
                      readonly
                      v-on="on"
                    ></v-text-field>
                  </template>
                  <v-date-picker v-model="dateEnd" @input="menu3 = false"></v-date-picker>
                </v-menu>
              </v-col>
              <v-col cols="12" sm="6" md="4">
                <v-select
                  v-model="idTerpia"
                  :items="terapias"
                  item-value="idTerapia"
                  item-text="descripcion"
                  label="Seleccione la terapia"
                  :rules="rulesInput"
                ></v-select>
              </v-col>
              <v-col cols="12" sm="6" md="4" >
                <v-select
                  v-model="idEstado"
                  :items="estados"
                  item-value="idEstado"
                  item-text="nombre"
                  label="Seleccione el estado"
                  :rules="rulesInput"
                ></v-select>
              </v-col>
              <v-col cols="12" sm="6" md="4">
                    <v-btn color="success" block large >Buscar citas</v-btn>
              </v-col>
            </v-row>
            <template>
              <v-sheet height="500">
                <v-calendar type="month" now="2019-01-08" value="2019-01-08" :events="events"></v-calendar>
              </v-sheet>
            </template>
          </v-card-text>
        </v-card>
      </v-card>
    </v-dialog>
  </v-row>
</template>

<script>
import AlertErrorGlobal from "../alertas/alertErrorGlobal.vue";
export default {
  components: {
    AlertErrorGlobal
  },
  props: {
    showCitesModal: Boolean,
    errorDB: Boolean,
    terapias: Array,
    estados: Array
  },
  data() {
    return {
      dialog: false,
      notifications: false,
      sound: true,
      widgets: false,
      events: [
        {
          name: "Vacation",
          start: "2018-12-30",
          end: "2019-01-02"
        },
        {
          name: "Meeting",
          start: "2019-01-07"
        },
        {
          name: "30th Birthday",
          start: "2019-01-03"
        },
        {
          name: "New Year",
          start: "2019-01-01"
        },
        {
          name: "Conference",
          start: "2019-01-21"
        },
        {
          name: "Hackathon",
          start: "2019-01-30",
          end: "2019-02-01"
        }
      ],
      DateType: new Date().toISOString().substr(0, 10),
      dateStart: new Date().toISOString().substr(0, 10),
      dateEnd: new Date().toISOString().substr(0, 10),
      menu1: false,
      menu2: false,
      menu3: false,
      idTerpia: "",
      idEstado: "",
      rulesInput: [V => !!V || "El campo es requerido"]
    };
  },
  methods: {
    closeModal() {
      this.$emit("closeModal");
    }
  }
};
</script>
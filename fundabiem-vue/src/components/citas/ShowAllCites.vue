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

        <v-card class="pl-5 pr-5">
          <v-card-text>
            <alert-error-global
              v-if="errorDB"
              message="Ocurrio un inconveniente intente más tarde!"
            />
            <v-form v-model="formCitesValue" ref="citeRef">
              <v-row>
                <v-col cols="12" sm="6" md="3">
                  <v-select
                    v-model="DateType"
                    :items="tipos"
                    :rules="rulesInput"
                    label="Seleccione tipo"
                    hint="El campo es requerido"
                  ></v-select>
                </v-col>
                <v-col cols="12" sm="6" md="3">
                  <v-select
                    v-model="range"
                    :items="ranges"
                    item-value="id"
                    item-text="valor"
                    :rules="rulesInput"
                    label="Seleccione filtro de búsqueda"
                    hint="El campo es requerido"
                    @change="filtroBusqueda"
                  ></v-select>
                </v-col>
                <v-col cols="12" sm="6" md="3" v-if="showInput">
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
                        v-on="on"
                        :rules="rulesInput"
                        readonly
                        hint="El campo es requerido"
                      ></v-text-field>
                    </template>
                    <v-date-picker v-model="dateStart" @input="menu2 = false"></v-date-picker>
                  </v-menu>
                </v-col>
                <v-col cols="12" sm="6" md="3" v-if="showInput && range !== 1">
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
                        :rules="rulesInput"
                        v-model="dateEnd"
                        label="Fecha final"
                        prepend-icon="event"
                        readonly
                        hint="El campo es requerido"
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
                    hint="El campo es requerido"
                    :rules="rulesInput"
                    :disabled="!showInput"
                  ></v-select>
                </v-col>
                <v-col cols="12" sm="6" md="4">
                  <v-select
                    v-model="idEstado"
                    :items="estados"
                    item-value="idEstado"
                    item-text="nombre"
                    label="Seleccione el estado"
                    hint="El campo es requerido"
                    :rules="rulesInput"
                    :disabled="!showInput"
                  ></v-select>
                </v-col>
                <v-col cols="12" sm="6" md="4">
                  <v-btn
                    :disabled="!formCitesValue"
                    color="success"
                    block
                    large
                    @click="searchFilter"
                  >Buscar citas</v-btn>
                </v-col>
              </v-row>
            </v-form>
            <template>
                 <v-menu bottom right>
            <template v-slot:activator="{ on }">
              <v-btn
                outlined
                v-on="on"
              >
                <span>{{ typeToLabel[type] }}</span>
                <v-icon right>mdi-menu-down</v-icon>
              </v-btn>
            </template>
            <v-list>
              <v-list-item @click="type = 'day'">
                <v-list-item-title>Day</v-list-item-title>
              </v-list-item>
              <v-list-item @click="type = 'week'">
                <v-list-item-title>Week</v-list-item-title>
              </v-list-item>
              <v-list-item @click="type = 'month'">
                <v-list-item-title>Month</v-list-item-title>
              </v-list-item>
              <v-list-item @click="type = '4day'">
                <v-list-item-title>4 days</v-list-item-title>
              </v-list-item>
            </v-list>
          </v-menu>
              <v-sheet height="600">
                           {{events}}
                <v-calendar
                  ref="calendar"
                  color="primary"
                  :events="events"
                  :event-color="getEventColor"
                  :event-margin-bottom="3"
                  :now="today"
                  :type="type"
                  @click:event="showEvent"
                  @click:more="viewDay"
                  @click:date="viewDay"
                  @change="updateRange"
                ></v-calendar>
 
                <v-menu
                  v-model="selectedOpen"
                  :close-on-content-click="false"
                  :activator="selectedElement"
                  offset-x
                >
                

                  <v-card color="grey lighten-4" min-width="350px" flat>
                    <v-toolbar :color="selectedEvent.color" dark>
                      <v-btn icon>
                        <v-icon>mdi-pencil</v-icon>
                      </v-btn>
                      <v-toolbar-title v-html="selectedEvent.name"></v-toolbar-title>
                      <v-spacer></v-spacer>
                      <v-btn icon>
                        <v-icon>mdi-heart</v-icon>
                      </v-btn>
                      <v-btn icon>
                        <v-icon>mdi-dots-vertical</v-icon>
                      </v-btn>
                    </v-toolbar>
                    <v-card-text>
                      <span v-html="selectedEvent.details"></span>
                    </v-card-text>
                    <v-card-actions>
                      <v-btn text color="secondary" @click="selectedOpen = false">Cancel</v-btn>
                    </v-card-actions>
                  </v-card>
                </v-menu>
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
      // events: [
      //   { name: "Vacation", start: "2018-12-30", end: "2019-01-02" },
      //   { name: "Meeting", start: "2019-01-07" },
      //   { name: "30th Birthday", start: "2019-01-03" },
      //   { name: "New Year", start: "2019-01-01" },
      //   { name: "Conference", start: "2019-01-21" },
      //   { name: "Hackathon", start: "2019-01-30", end: "2019-02-01" }
      // ],
      DateType: "",
      dateStart: new Date().toISOString().substr(0, 10),
      dateEnd: new Date().toISOString().substr(0, 10),
      tipos: ["fechaCita", "fechaAsignacion"],
      range: "",
      ranges: [
        { id: 1, valor: "Fecha inicial" },
        { id: 2, valor: "Rango de fechas" }
      ],
      menu2: false,
      menu3: false,
      idTerpia: "",
      idEstado: "",
      rulesInput: [V => !!V || "El campo es requerido"],
      showInput: false,
      formCitesValue: false,

      // data nueva
        today: '2019-01-01',
      type: 'month',
      typeToLabel: {
        month: 'Month',
        week: 'Week',
        day: 'Day',
        '4day': '4 Days',
      },
      start: null,
      end: null,
      selectedEvent: {},
      selectedElement: null,
      selectedOpen: false,
      events: [],
      // events: [
      //   { name: 'Vacation', details: 'Going to the beach!', start: '2018-12-29', color: 'blue', },
      //   { name: 'Meeting', details: 'Spending time on how we do not have enough time', start: '2019-01-07 09:00', color: 'indigo',  },
      //   { name: 'Large Event', details: 'This starts in the middle of an event and spans over multiple events', start: '2018-12-31', color: 'deep-purple',  },
      //   { name: '3rd to 7th', details: 'Testing', start: '2019-01-03',color: 'cyan',  },
      //   { name: 'Big Meeting', details: 'A very important meeting about nothing', start: '2019-01-07 08:00',   color: 'red', },
      //   { name: 'Another Meeting', details: 'Another important meeting about nothing', start: '2019-01-07 10:00',   color: 'brown', },
      //   { name: '7th to 8th', start: '2019-01-07', color: 'blue', },
      //   { name: 'Lunch', details: 'Time to feed', start: '2019-01-07 12:00',color: 'deep-orange', },
      //   { name: '30th Birthday', details: 'Celebrate responsibly', start: '2019-01-03', color: 'teal', },
      //   { name: 'New Year', details: 'Eat chocolate until you pass out', start: '2019-01-01',    color: 'green',  },
      //   { name: 'Conference', details: 'The best time of my life', start: '2019-01-21',   color: 'grey darken-1', },
      //   { name: 'Hackathon', details: 'Code like there is no tommorrow', start: '2019-01-30 23:00',   color: 'black', },
      //   { name: 'event 1', start: '2019-01-14 18:00',  color: '#4285F4', },
      //   { name: 'event 2', start: '2019-01-14 18:00',  color: '#4285F4', },
      //   { name: 'event 5', start: '2019-01-14 18:00',  color: '#4285F4', },
      //   { name: 'event 3', start: '2019-01-14 18:30',  color: '#4285F4', },
      //   { name: 'event 4', start: '2019-01-14 19:00',  color: '#4285F4', },
      //   { name: 'event 6', start: '2019-01-14 21:00',  color: '#4285F4', },
      //   { name: 'event 7', start: '2019-01-14 22:00',  color: '#4285F4', },
      // ],
    };
  },

     computed: {
    //   title () {
    //     const { start, end } = this
    //     if (!start || !end) {
    //       return ''
    //     }

    //     const startMonth = this.monthFormatter(start)
    //     const endMonth = this.monthFormatter(end)
    //     const suffixMonth = startMonth === endMonth ? '' : endMonth

    //     const startYear = start.year
    //     const endYear = end.year
    //     const suffixYear = startYear === endYear ? '' : endYear

    //     const startDay = start.day + this.nth(start.day)
    //     const endDay = end.day + this.nth(end.day)

    //     switch (this.type) {
    //       case 'month':
    //         return `${startMonth} ${startYear}`
    //       case 'week':
    //       case '4day':
    //         return `${startMonth} ${startDay} ${startYear} - ${suffixMonth} ${endDay} ${suffixYear}`
    //       case 'day':
    //         return `${startMonth} ${startDay} ${startYear}`
    //     }
    //     return ''
    //   },
    //   monthFormatter () {
    //     return this.$refs.calendar.getFormatter({
    //       timeZone: 'UTC', month: 'long',
    //     })
    //   },
    },
  methods: {
    async searchFilter() {
      
      const data = {
        DateType: this.DateType,
        dateStart: this.dateStart,
        dateEnd: this.dateEnd ? this.dateEnd : null,
        range: this.range === 1 ? false : true,
        idTerpia: this.idTerpia,
        idEstado: this.idEstado
      };

      console.log(data);
      const response = await this.$store.dispatch("getAllCites", data);

      console.log(response.data)

      if(response.status === 200) {

        response.data.map( cita => {
          const { idTerapia, dPaciente, fechaCita, noOrden, idCita } = cita
          const fecha = fechaCita.split("T")[0]
          console.log(fecha)

          this.events.push({
            idTerapia, 
            dPaciente, 
            start: fecha, 
            name: noOrden, 
            details: noOrden,
            idCita ,
            color: "black"
          })
        })
            // { "idTerapia": 1, "dPaciente": 2, "start": "2019-11-07", "name": "1111", "idCita": 20, "color": "#000" }
        //  { name: 'Hackathon', details: 'Code like there is no tommorrow', start: '2019-01-30 23:00',   color: 'black', },

        console.log(this.events)
      }
       

      this.$refs.citeRef.reset();
      this.showInput = false;
    },
    closeModal() {
      this.$emit("closeModal");
      this.$refs.citeRef.reset();
      this.showInput = false;
    },
    filtroBusqueda() {
      this.showInput = true;
    },
   
     viewDay ({ date }) {
        this.focus = date
        this.type = 'day'
      },
      getEventColor (event) {
        return event.color
      },
      setToday () {
        this.focus = this.today
      },
      prev () {
        this.$refs.calendar.prev()
      },
      next () {
        this.$refs.calendar.next()
      },
      showEvent ({ nativeEvent, event }) {
        const open = () => {
          this.selectedEvent = event
          this.selectedElement = nativeEvent.target
          setTimeout(() => this.selectedOpen = true, 10)
        }

        if (this.selectedOpen) {
          this.selectedOpen = false
          setTimeout(open, 10)
        } else {
          open()
        }

        nativeEvent.stopPropagation()
      },
      updateRange ({ start, end }) {
        // You could load events from an outside source (like database) now that we have the start and end dates on the calendar
        this.start = start
        this.end = end
      },
      nth (d) {
        return d > 3 && d < 21
          ? 'th'
          : ['th', 'st', 'nd', 'rd', 'th', 'th', 'th', 'th', 'th', 'th'][d % 10]
      },
  },

};
</script>
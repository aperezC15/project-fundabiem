
<template>
  <v-row justify="center">
    <v-dialog v-model="dialogRehabilitacion" persistent fullscreen hide-overlay transition="dialog-bottom-transition">
     
      <v-card>
           <v-toolbar dark color="#2c2e3f">
          
          <span class=" headline text-uppercase">Nuevo ciclo de rehabilitación</span>
          <div class="flex-grow-1"></div>
            <v-btn color="indigo" rounded  @click="closeModalRehabilitation" class="mx-4">CERRAR</v-btn>
            <v-btn color="indigo" rounded :disabled="!formValid"  @click="saveRehabilitacion">GUARDAR REGISTRO</v-btn>
        </v-toolbar>
       
        <v-card-text>
          <v-container>
            <v-form ref="formRef" v-model="formValid">
                <v-row>
                    <v-col cols="12" md="8">
                        <v-text-field v-model="nombreCompleto" :rules="rulesInput" label="Nombre completo" hint="El campo es requerido" ></v-text-field>
                    </v-col>
                    <v-col cols="12"  md="4">
                        <v-text-field v-model="edad" :rules="rulesInput" type="number" label="Edad" hint="El campo es requerido"></v-text-field>
                    </v-col>
                    <v-col cols="12" sm="6" >
                        <v-select v-model="sexo" :items="sexosArray" :rules="rulesInput" item-value="id" item-text="valor" label="Sexo" hint="El campo es requerido"
                        ></v-select>
                    </v-col>
                    <v-col cols="12" sm="6">
                        <v-text-field v-model="origen" :rules="rulesInput" label="Origen" hint="El campo es requerido" ></v-text-field>
                    </v-col>
                    <v-col cols="12">
                        <v-text-field v-model="diagnostico" :rules="rulesInput" label="Diagnóstico" hint="El campo es requerido"
                        required></v-text-field>
                    </v-col>
                    <v-col cols="12" sm="6" md="4">
                        <v-text-field v-model="cie" label="CIE 10" hint="El campo es requerido"
                        required></v-text-field>
                    </v-col>
                    <v-col cols="12" sm="6" md="4">
                        <v-text-field v-model="otros" label="Otros" hint="El campo es requerido"
                        required></v-text-field>
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
                                v-model="date"
                                label="Fecha"
                                prepend-icon="event"
                                readonly
                                v-on="on"
                            ></v-text-field>
                            </template>
                            <v-date-picker v-model="date" @input="menu2 = false"></v-date-picker>
                        </v-menu>
                    </v-col>
                    <v-col cols="12" sm="6" md="4">
                        <v-textarea
                            v-model="estructurasCorporales"
                            solo
                            name="input-7-4"
                            label="Funciones-Estructuras Corporales"
                            auto-grow
                        ></v-textarea>
                    </v-col>
                    <v-col cols="12" sm="6" md="4">
                        <v-textarea
                            v-model="actividad"
                            solo
                            name="input-7-4"
                            label="Actividad"
                            auto-grow
                        ></v-textarea>
                    </v-col>
                    <v-col cols="12" sm="6" md="4">
                        <v-textarea
                            v-model="participacion"
                            solo
                            name="input-7-4"
                            label="Participación"
                            auto-grow
                        ></v-textarea>
                    </v-col>
                </v-row>
            </v-form>
          </v-container>
         
        </v-card-text>
      
      </v-card>
    </v-dialog>
  </v-row>
</template>
    
<script>
export default {
    props: {
        dialogRehabilitacion: Boolean
    },
    data() {
        return {
            sexosArray: [
                { id: 1, valor: "Masculino", },
                { id: 2, valor: "Femenino"}
            ],
             date: new Date().toISOString().substr(0, 10),
            menu2: false,
            nombreCompleto: '',
            edad: '',
            sexo: '',
            origen: '',
            diagnostico: '',
            cie: '',
            otros: '',
            estructurasCorporales: '',
            actividad: '',
            participacion: '',
            formValid: false,
            rulesInput: [
                v => !! v || "El campo es obligatorio"
            ]
        }
    },
    methods: {
        closeModalRehabilitation() {
            this.$emit('closeModalRehabilitation')

            this.$refs.formRef.reset()
        },
        saveRehabilitacion() {
            const data = {
                "id":  Math.random().toString(36).substr(2, 9),
                "nombre" : this.nombreCompleto,
                "edad": this.edad,
                "sexo": this.sexo,
                "origen": this.origen,
                "diagnostico": this.diagnostico,
                "cie": this.cie,
                "otros": this.otros,
                "fecha" : this.date,
                "estructurasCorporales": this.estructurasCorporales,
                "actividad": this.actividad,
                "participacion": this.participacion,
            }

            if(this.$refs.formRef.validate()) {
                this.$emit('saveRehabilitacion', data)
            }

            this.$refs.formRef.reset()
        },
    }
}

</script>
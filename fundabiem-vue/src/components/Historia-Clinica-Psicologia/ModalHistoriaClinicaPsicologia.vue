<template>
    <div>
        <!-- INICIO DE LA ESTRUCTURA DEL DIALOGO DE LA EVOLUCION MEDICA DE DIAGNOSTICO -->
        <v-dialog v-model="ModalHistoriaPsicologica" fullscreen hide-overlay transition="dialog-bottom-transition" >
            <v-card>
                <!-- ENCABEZADO DEL MODAL DE HISTORIA PSICOLOGICA -->
                <v-toolbar dark color="#2c2e3f">
                    <span class="headline">{{ModalTitle}}</span>
                    <div class="flex-grow-1"></div>

                    <v-btn color="indigo" rounded class="mx-4" @click="CloseModalHistoriaPsicologica()">CERRAR</v-btn>
                    <v-btn color="indigo" rounded @click="SaveHistoriaPsicologica()" >GUARDAR DIAGNOSTICO</v-btn>
                </v-toolbar>
                <!-- CUERPO DEL FORMULARIO  -->
                <v-card-text>
                    <v-stepper v-model="PasoAPaso">
                        <!-- ENCABEZADO DEL STEPPERS -->
                        <v-stepper-header>
                            <v-stepper-step :complete="PasoAPaso > 1" step="1" color="#2c2e3f">DATOS GENERALES</v-stepper-step>
                            <v-divider></v-divider>

                            <v-stepper-step :complete="PasoAPaso > 2" step="2" color="#2c2e3f">CONSULTA - ANTECEDENTES</v-stepper-step>
                            <v-divider></v-divider>

                            <v-stepper-step :complete="PasoAPaso > 3" step="3" color="#2c2e3f">PERFIL - PERSONALIDAD</v-stepper-step>
                            <v-divider></v-divider>

                            <v-stepper-step :complete="PasoAPaso > 4" step="4" color="#2c2e3f">EXAMEN MENTAL</v-stepper-step>
                            <v-divider></v-divider>

                            <v-stepper-step :complete="PasoAPaso > 5" step="5" color="#2c2e3f">FAMILIA - DIAGNOSTICO</v-stepper-step>
                            <v-divider></v-divider>

                            <v-stepper-step :complete="PasoAPaso > 6" step="6" color="#2c2e3f">PLAN PSICOLOGICO</v-stepper-step>

                        </v-stepper-header>
                        <!-- CUERPO DE CADA STEPPERS -->
                        <v-stepper-items>
                            <v-stepper-content step="1">
                                <v-card>
                                    <v-form>
                                        <v-row>
                                            <v-col cols="12" md="4">
                                                <v-text-field v-model="editedItem.NombreHP" label="NOMBRE COMPLETO"></v-text-field>
                                            </v-col>
                                            <v-col cols="12" md="4">
                                                <v-select v-model="editedItem.SexoHP" label="SEXO" :items="itemsexo"></v-select>
                                            </v-col>
                                            <v-col cols="12" md="4">
                                                <v-text-field v-model="editedItem.EdadHP" label="EDAD" type="number"></v-text-field>
                                            </v-col>
                                        </v-row>
                                    </v-form>
                                </v-card>
                            </v-stepper-content>
                        </v-stepper-items>
                    </v-stepper>
                </v-card-text>

            </v-card>
        </v-dialog>
        <!-- FIN DEL FORMULARIO DE EVOLUCION MEDICA  -->        
    </div>
</template>

<script>
export default {
    props: {
        ModalHistoriaPsicologica: Boolean,
        ModalTitle: String
    },    

    data: () => ({
        PasoAPaso: 0,
        itemsexo: ['MASCULINO', 'FEMENINO'],

    }),

    methods: {
        CloseModalHistoriaPsicologica(){
            this.$emit('close-modal-historia-psicologica')
        },        

        // llamamos las varialbes que se usaran en el modal del formulario y se guardaran en la tabla
        editedItem(){
            this.$emit('variables')
        },

        SaveHistoriaPsicologica(){
            this.$emit('Save-Historia-Psicologica')
      
        },

        editedIndex(){
            this.$emit('editedIndexModal')
        },

        defaultItem(){
            this.$emit('defaultItem')
        },

        editItem(){
            this.$emit('editItem')
        }
    },
}
</script>
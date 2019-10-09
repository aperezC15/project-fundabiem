<template>
    <div>
        <!-- INICIO DE LA ESTRUCTURA DEL DIALOGO DEL FORMULARIO DE HISTORIA CLINICA PSICOLOGICA -->
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
                <v-stepper v-model="PasoAPaso">
                    <!-- ENCABEZADO DEL STEPPERS -->
                    <v-stepper-header>
                        <v-stepper-step :complete="PasoAPaso > 1" editable edit-icon="check" step="1" color="#2c2e3f" title="DATOS GENERALES">DATOS GENERALES</v-stepper-step>
                        <v-divider></v-divider>

                        <v-stepper-step :complete="PasoAPaso > 2" editable edit-icon="check" step="2" color="#2c2e3f" title="MOTIVO DE LA CONSULTA Y ANTECEDENTES DEL PACIENTE">CONSULTA - ANTECEDENTES</v-stepper-step>
                        <v-divider></v-divider>

                        <v-stepper-step :complete="PasoAPaso > 3" editable edit-icon="check" step="3" color="#2c2e3f" title="PERFIL SOCIAL Y PERSONALIDAD">PERFIL - PERSONALIDAD</v-stepper-step>
                        <v-divider></v-divider>

                        <v-stepper-step :complete="PasoAPaso > 4" editable edit-icon="check" step="4" color="#2c2e3f" title="EXAMEN MENTAL">EXAMEN MENTAL</v-stepper-step>
                        <v-divider></v-divider>

                        <v-stepper-step :complete="PasoAPaso > 5" editable edit-icon="check" step="5" color="#2c2e3f" title="DATOS SOBRE LA FAMILIA, DIAGNOSTICO DEL PACIENTE Y PLAN PSICOLOGICO">FAMILIA - DIAGNOSTICO - PLAN PSICOLOGICO</v-stepper-step>                            

                    </v-stepper-header>
                    <!-- CUERPO DE CADA STEPPERS -->
                    <v-stepper-items>
                        <v-stepper-content step="1">
                            <v-form>
                                <!-- DATOS GENERALES ---------------------------- -->
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
                                <v-row>
                                    <v-col cols="12" md="6">
                                        <v-text-field v-model="editedItem.EstudiosHP" label="ESTUDIOS"></v-text-field>
                                    </v-col>
                                    <v-col cols="12" md="6">
                                        <v-text-field v-model="editedItem.OrigenHP" label="ORIGEN Y PROCEDENCIA"></v-text-field>
                                    </v-col>
                                </v-row>
                                <v-row>
                                    <v-col cols="12" md="6">
                                        <v-text-field v-model="editedItem.OcupacionHP" label="OCUPACION"></v-text-field>
                                    </v-col>
                                    <v-col cols="12" md="3">
                                        <v-select v-model="editedItem.EstadoCivilHP" label="ESTADO CIVIL" :items="itemEstadoCivil"></v-select>
                                    </v-col>
                                    <v-col cols="12" md="3">
                                        <v-select v-model="editedItem.ReligionHP" label="RELIGION"></v-select>
                                    </v-col>
                                </v-row>
                                <v-row>
                                    <v-col cols="12" md="12">
                                        <v-text-field v-model="editedItem.ProgenitorHP" label="DATOS DE LOS PROGENITORES"></v-text-field>
                                    </v-col>
                                </v-row>
                            </v-form>
                            <v-btn color="indigo" rounded dark @click="IrPaso2">SIGUIENTE</v-btn>
                        </v-stepper-content>
                        <v-stepper-content step="2">
                            <v-form>
                                <v-row>
                                    <v-col>
                                        <v-textarea v-model="editedItem.MotivoConsultaHP" label="MOTIVO DE LA CONSULTA" auto-grow outlined ></v-textarea>
                                    </v-col>
                                </v-row>
                                <v-row>
                                    <v-col>
                                        <v-textarea v-model="editedItem.AntecedentesPacienteHP" label="ANTECEDENTES DEL PACIENTE" auto-grow outlined></v-textarea>
                                    </v-col>
                                </v-row>
                            </v-form>
                            <v-btn color="indigo" rounded dark @click="IrPaso3()">SIGUIENTE</v-btn>
                        </v-stepper-content>
                        <v-stepper-content step="3">
                            <v-form>
                                <v-row>
                                    <v-col>
                                        <v-textarea v-model="editedItem.PerfilSocialHP" label="PERFIL SOCIAL" auto-grow outlined></v-textarea>
                                    </v-col>
                                </v-row>
                                <v-row>
                                    <v-col>
                                        <v-textarea v-model="editedItem.PersonalidadHP" label="PERSONALIDAD" auto-grow outlined></v-textarea>
                                    </v-col>
                                </v-row>
                            </v-form>
                            <v-btn color="indigo" rounded dark @click="IrPaso4()">SIGUIENTE</v-btn>
                        </v-stepper-content>
                        <v-stepper-content step="4">
                            <v-form>
                                <v-row>
                                    <v-col md="4">
                                        <v-textarea v-model="editedItem.AparienciaGeneralHP" label="APARIENCIA GENERAL Y ACTITUD" auto-grow outlined></v-textarea>
                                    </v-col>
                                    <v-col md="4">
                                        <v-textarea v-model="editedItem.EstadoConcienciaHP" label="ESTADO DE CONCIENCIA" auto-grow outlined></v-textarea>
                                    </v-col>
                                    <v-col md="4">
                                        <v-textarea v-model="editedItem.EstadoAnimoHP" label="ESTADO DE ANIMO" auto-grow outlined></v-textarea>
                                    </v-col>
                                </v-row>
                                <v-row>
                                    <v-col md="4">
                                        <v-textarea v-model="editedItem.ActividadMotoraHP" label="ACTIVIDAD MOTORA" auto-grow outlined></v-textarea>
                                    </v-col>
                                    <v-col md="4">
                                        <v-textarea v-model="editedItem.AsociacionHP" label="ASOCIACION Y FLUJO DE IDEAS" hint="ASOCIACION Y FLUJO DE IDEAS Y CARACTERISTICAS DEL LENGUAJE" auto-grow outlined></v-textarea>
                                    </v-col>
                                    <v-col md="4">
                                        <v-textarea v-model="editedItem.ContenidoIdeasHP" label="CONTENIDO DE IDEAS" auto-grow outlined></v-textarea>
                                    </v-col>                                        
                                </v-row>
                                <v-row>
                                    <v-col md="3">
                                        <v-textarea v-model="editedItem.SensoriumHP" label="SENSORIUM" auto-grow outlined></v-textarea>
                                    </v-col>
                                    <v-col md="3">
                                        <v-textarea v-model="editedItem.MemoriaHP" label="MEMORIA" auto-grow outlined></v-textarea>
                                    </v-col>
                                    <v-col md="3">
                                        <v-textarea v-model="editedItem.PensamientoHP" label="PENSAMIENTO" auto-grow outlined></v-textarea>
                                    </v-col>
                                    <v-col md="3">
                                        <v-textarea v-model="editedItem.ResultadoHP" label="RESULTADO DEL EXAMEN" auto-grow outlined></v-textarea>
                                    </v-col>
                                </v-row>
                                <v-btn color="indigo" rounded dark @click="IrPaso5">SIGUIENTE</v-btn>
                            </v-form>
                        </v-stepper-content>
                        <v-stepper-content step="5">
                            <v-form>
                                <v-row>
                                    <v-col md="12">
                                        <v-textarea v-model="editedItem.DatosRelevantesHP" label="DATOS RELEVANTES SOBRE LA FAMILIA DEL PACIENTE" auto-grow outlined></v-textarea>
                                    </v-col>
                                </v-row>
                                <v-row>
                                    <v-col md="12">
                                        <v-textarea v-model="editedItem.DiagnosticoHP" label="DIAGNOSTICO" auto-grow outlined></v-textarea>
                                    </v-col>
                                </v-row> 
                                <v-row>
                                    <v-col md="12">
                                        <v-textarea v-model="editedItem.PlanOrientacionHP" label="PLAN DE ORIENTACION PSICOLOGICA" auto-grow outlined></v-textarea>
                                    </v-col>
                                </v-row>
                            </v-form>
                        </v-stepper-content>
                    </v-stepper-items>
                </v-stepper>
            </v-card>
        </v-dialog>
        <!-- FIN DEL FORMULARIO   -->        
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
        itemEstadoCivil: ['Soltero/a','Comprometido/a', 'En Relacion', 'Casado/a', 'Separado/a', 'Divorciado/a', 'Viudo/a'],
        
    }),

    methods: {
        IrPaso2 (){
            this.PasoAPaso = 2
        },

        IrPaso3 (){
            this.PasoAPaso = 3
        },

        IrPaso4 (){
            this.PasoAPaso = 4
        },

        IrPaso5 (){
            this.PasoAPaso = 5
        },

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
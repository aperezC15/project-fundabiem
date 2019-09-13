<template>
    <div>
        <!-- AQUI INICIAMOS EL DIALOGO QUE CONTENDRA EL FORMULARIO DEL ESTUDIO SOCIOECONOMICO -->
        <v-dialog v-model="DialogoNuevoES" persistent max-width="1200px">
            <!-- INICIO DE LA ESTRUCTURA DE PASOS STEPPER PARA EL REGISTROS DE DATOS -->
            <v-stepper v-model="PasosDeFormulario">
                <br>
                <v-layout text-center>
                    <v-flex>
                        <span class="headline"> {{formtitle}}</span>
                    </v-flex>
                </v-layout>
                <br>
                <!-- INICIO DEL ENCABEZADO DE LOS PASOS DE REGISTROS -->
                <v-stepper-header >
                    <v-stepper-step :complete="PasosDeFormulario > 1" step="1" color="#2c2e3f">PASO 1</v-stepper-step>
                    <v-divider></v-divider>

                    <v-stepper-step :complete="PasosDeFormulario > 2" step="2" color="#2c2e3f">DATOS GENERALES</v-stepper-step>
                    <v-divider></v-divider>

                    <v-stepper-step :complete="PasosDeFormulario > 3" step="3" color="#2c2e3f">GRUPO FAMILIAR</v-stepper-step>
                    <v-divider></v-divider>

                    <v-stepper-step :complete="PasosDeFormulario > 4" step="4" color="#2c2e3f">VIVIENDA</v-stepper-step>
                    <v-divider></v-divider>

                    <v-stepper-step :complete="PasosDeFormulario > 5" step="5" color="#2c2e3f">OBSERVACIONES</v-stepper-step>
                </v-stepper-header>
                <!-- FIN DEL ENCABEZADO DE LOS PASOS DE REGISTROS -->
                <!-- INICIO DE LOS ESPACIOS DE REGISTROS DE CADA PASO  -->
                <v-stepper-items>
                    <!-- PRIMER PASO PARA EL REGISTRO DE DATOS -->
                    <v-stepper-content step="1">
                        <v-form v-model="valid">
                            <v-container>
                                <v-row>
                                    <v-col cols="12" ms="6" md="6">                                                    
                                        <v-text-field v-model="editedItem.RegMedicoNo" label="REG. MEDICO NO." :rules="nameRules" required></v-text-field>
                                    </v-col>
                                    <v-col cols="12" ms="6" md="6">
                                        <v-text-field v-model="editedItem.RegSocialNo" label="REG. SOCIAL. NO." :rules="nameRules" required></v-text-field>
                                    </v-col>
                                    <!-- fecha de ingreso -->
                                    <v-col cols="12" ms="6" md="6"> 
                                        <v-dialog
                                            ref="dialog"
                                            v-model="modaldatefechaingreso"
                                            return-value.sync="datefechaingreso"
                                            persistent
                                            width="290px"
                                        >
                                            <template v-slot:activator="{ on }">
                                            <v-text-field
                                                v-model="editedItem.datefechaingreso"
                                                label="Fecha de Ingreso"
                                                prepend-icon="event"
                                                readonly
                                                v-on="on"
                                            ></v-text-field>
                                            </template>
                                            <v-date-picker v-model="editedItem.datefechaingreso" color="#2c2e3f" scrollable>
                                            <div class="flex-grow-1"></div>
                                            <v-btn text color="primary" @click="modaldatefechaingreso = false">CANCELAR</v-btn>
                                            <v-btn text color="primary" @click="$refs.dialog.save(editedItem.datefechaingreso)">OK</v-btn>
                                            </v-date-picker>
                                        </v-dialog>
                                    </v-col>
                                    <!-- fecha de entrevista -->
                                    <v-col cols="12" ms="6" md="6">
                                        <v-dialog
                                            ref="dialog2"
                                            v-model="modaldatefechaentrevista"
                                            return-value.sync="datefechaentrevista"
                                            persistent
                                            width="290px"
                                        >
                                            <template v-slot:activator="{ on }">
                                            <v-text-field
                                                v-model="editedItem.datefechaentrevista"
                                                label="FECHA DE ENTREVISTA"
                                                prepend-icon="event"
                                                readonly
                                                v-on="on"
                                            ></v-text-field>
                                            </template>
                                            <v-date-picker v-model="editedItem.datefechaentrevista" color="#2c2e3f" scrollable>
                                            <div class="flex-grow-1"></div>
                                            <v-btn text color="primary" @click="modaldatefechaentrevista = false">CANCELAR</v-btn>
                                            <v-btn text color="primary" @click="$refs.dialog2.save(editedItem.datefechaentrevista)">OK</v-btn>
                                            </v-date-picker>
                                        </v-dialog>
                                    </v-col>
                                    <v-col cols="12" ms="6" md="12">                                                        
                                        <v-text-field v-model="editedItem.TSEntrevisto" label="T.S. ENTREVISTO" :rules="nameRules" required></v-text-field>
                                    </v-col> 
                                    <v-col cols="12" ms="6" md="12">
                                        <v-text-field v-model="editedItem.evaluo" label="EVALUO" :rules="nameRules" required></v-text-field>
                                    </v-col>
                                </v-row>
                            </v-container>
                        </v-form>
                        <v-btn rounded color="#01579B" @click="PasosDeFormulario = 2" dark>SIGUIENTE</v-btn>
                    </v-stepper-content>
                    <!-- FIN DEL PRIMER PASO -->
                    <!-- INICIO DEL SEGUNDO PASO DE DATOS GENERALES-->
                    <v-stepper-content step="2">
                        <v-form v-model="valid">
                            <v-container>
                                <v-row>
                                    <v-col cols="12" md="6">
                                        <v-text-field v-model="editedItem.NombreUsuario" label="NOMBRE DE USUARIO" :rules="nameRules" required></v-text-field>
                                    </v-col>
                                    <v-col cols="12" md="6">
                                        <v-text-field v-model="editedItem.escolaridad" label="ESCOLARIDAD" :rules="nameRules" required></v-text-field>
                                    </v-col>    
                                    <v-col cols="12" md="6">
                                        <v-text-field v-model="editedItem.direccion" label="DIRECCION" :rules="nameRules" required></v-text-field>
                                    </v-col>
                                    <v-col cols="12" md="6">
                                        <v-text-field v-model="editedItem.telefono" label="TELEFONO" :rules="nameRules" required></v-text-field>
                                    </v-col>
                                    <v-col cols="12" md="12">
                                        <v-text-field v-model="editedItem.permanente" label="PERMANENTE" :rules="nameRules" required></v-text-field>
                                    </v-col>
                                    <v-col cols="12" md="12">
                                        <v-text-field v-model="editedItem.temporal" label="TEMPORAL" :rules="nameRules" required></v-text-field>
                                    </v-col>
                                    <v-col cols="12" md="3">
                                        <v-text-field v-model="editedItem.edad" label="EDAD" :rules="nameRules" required></v-text-field>
                                    </v-col>
                                    <v-col cols="12" md="3">
                                        <v-select v-model="editedItem.sexo" :items="itemsexo" label="SEXO" :rules="nameRules" required></v-select>
                                    </v-col>
                                    <v-col cols="12" md="3">
                                        <v-text-field v-model="editedItem.lugarnacimiento" label="LUGAR NACIMIENTO" :rules="nameRules" required></v-text-field>
                                    </v-col>
                                    <!-- fecha de nacimiento -->
                                    <v-col cols="12" md="3"> 
                                        <v-dialog
                                            ref="dialog3"
                                            v-model="modaldatefechanacimiento"
                                            return-value.sync="datefechanacimiento"
                                            persistent
                                            width="290px"
                                        >
                                            <template v-slot:activator="{ on }">
                                            <v-text-field
                                                v-model="editedItem.datefechanacimiento"
                                                label="FECHA DE NACIMIENTO"
                                                prepend-icon="event"
                                                readonly
                                                v-on="on"
                                            ></v-text-field>
                                            </template>
                                            <v-date-picker v-model="editedItem.datefechanacimiento" color="#2c2e3f" scrollable>
                                            <div class="flex-grow-1"></div>
                                            <v-btn text color="primary" @click="modaldatefechanacimiento = false">CANCELAR</v-btn>
                                            <v-btn text color="primary" @click="$refs.dialog3.save(editedItem.datefechanacimiento)">OK</v-btn>
                                            </v-date-picker>
                                        </v-dialog>
                                    </v-col>
                                    <v-col cols="12" md="8">
                                        <v-text-field v-model="editedItem.atendidopor" label="ATENDIDO POR" :rules="nameRules" required></v-text-field>
                                    </v-col> 
                                    <v-col cols="12" md="4">
                                        <v-text-field v-model="editedItem.religion" label="RELIGION" :rules="nameRules" required></v-text-field>
                                    </v-col>
                                    <v-col cols="12" md="12">
                                        <v-text-field v-model="editedItem.medico" label="DR. MEDICO" :rules="nameRules" required></v-text-field>
                                    </v-col>
                                    <v-col cols="12" md="12">
                                        <v-text-field v-model="editedItem.servicio" label="SERVICIO" :rules="nameRules" required></v-text-field>
                                    </v-col>
                                    <!-- GRUPO DE CHECKBOX -->
                                    <v-col cols="12" md="1">
                                        <v-checkbox v-model="editedItem.ft" label="FT"></v-checkbox>
                                    </v-col>
                                    <v-col cols="12" md="2">
                                        <v-checkbox v-model="editedItem.piscina" label="PISCINA"></v-checkbox>
                                    </v-col>
                                    <v-col cols="12" md="1"> 
                                        <v-checkbox v-model="editedItem.to" label="T.O"></v-checkbox>
                                    </v-col>
                                    <v-col cols="12" md="1">
                                        <v-checkbox v-model="editedItem.ti" label="T.I"></v-checkbox>
                                    </v-col>
                                    <v-col cols="12" md="1">
                                        <v-checkbox v-model="editedItem.ee" label="E.E"></v-checkbox>
                                    </v-col>
                                    <v-col cols="12" md="2">
                                        <v-checkbox v-model="editedItem.escuela" label="ESCUELA"></v-checkbox>
                                    </v-col>
                                    <v-col cols="12" md="2">
                                        <v-checkbox v-model="editedItem.psicol" label="PSICOL"></v-checkbox>
                                    </v-col>
                                    <v-col cols="12" md="2">
                                        <v-checkbox v-model="editedItem.indcasa" label="IND. CASA"></v-checkbox>
                                    </v-col>
                                    <!-- fin del grupo de checkbox -->
                                    <v-col cols="12" md="12">
                                        <v-text-field v-model="editedItem.motivosolicitud" label="MOTIVO DE SOLICITUD" :rules="nameRules" required></v-text-field>
                                    </v-col>
                                </v-row>
                            </v-container>
                        </v-form>
                        <v-btn class="ma-2" rounded dark color="#01579B" @click="IrPaso1()">PASO 1</v-btn>
                        <v-btn class="ma-2" rounded dark color="#01579B" @click="IrPaso3()">SIGUIENTE</v-btn>                        
                    </v-stepper-content>
                    <!-- FIN DEL SEGUNDO PASO DE DATOS GENERALES-->
                    <!-- INICIO DEL TERCER PASO DE DATOS DE GRUPO FAMILIAR -->
                    <v-stepper-content step="3">
                        <v-btn class="ma-2" rounded dark color="#01579B" @click="IrPaso1()">PASO 1</v-btn>
                        <v-btn class="ma-2" rounded dark color="#01579B" @click="IrPaso2()">2. DATOS GENERALES</v-btn>
                        <v-btn class="ma-2" rounded dark color="#01579B" @click="IrPaso4()">SIGUIENTE</v-btn>
                    </v-stepper-content>
                    <!-- FIN DEL TERCER PASO DE DATOS DE GRUPO FAMILIAR -->
                    <!-- INICIO DEL CUARTO PASO DATOS DE VIVIENDA -->
                    <v-stepper-content step="4">
                        <v-btn class="ma-2" rounded dark color="#01579B" @click="IrPaso1()">PASO 1</v-btn>
                        <v-btn class="ma-2" rounded dark color="#01579B" @click="IrPaso2">2. DATOS GENERALES</v-btn>
                        <v-btn class="ma-2" rounded dark color="#01579B" @click="IrPaso3()">3. GRUPO FAMILIAR</v-btn>
                        <v-btn class="ma-2" rounded dark color="#01579B" @click="IrPaso5">SIGUIENTE</v-btn>
                    </v-stepper-content>
                    <!-- FIN DEL CUARTO PASO DATOS DE VIVIENDA -->
                    <!-- INICIO DEL QUINTO PASO DE OBSERVACIONES  -->
                    <v-stepper-content step="5">
                        <v-btn class="ma-2" rounded dark color="#01579B" @click="IrPaso1()">1. PASO 1</v-btn>
                        <v-btn class="ma-2" rounded dark color="#01579B" @click="IrPaso2()">2. DATOS GENERALES</v-btn>
                        <v-btn class="ma-2" rounded dark color="#01579B" @click="IrPaso3()">3. GRUPO FAMILIAR</v-btn>
                        <v-btn class="ma-2" rounded dark color="#01579B" @click="IrPaso4()">4. VIVIENDA</v-btn>  
                        <v-divider class="mx-4" vertical></v-divider>
                        <v-btn class="ma-2" rounded dark color="#01579B" @click="CancelarDialogoRegistro()">CERRAR</v-btn>
                        <v-btn class="ma-2" rounded dark color="#01579B" @click="guardarNuevoES">GUARDAR ESTUDIO SOCIOECONOMICO</v-btn>
                                       
                    </v-stepper-content>
                    <!-- FIN DEL QUINTO PASO DE OBSERVACIONES -->
                </v-stepper-items>
                <!-- FIN DE LOS ESPACIOS DE REGISTROS DE CADA PASO -->
            </v-stepper>
        </v-dialog>
        <!-- FIN DEL DIALOGO PARA REGISTRAR UN NUEVO ESTUDIO SOCIOECONOMICO -->

        <v-container>            
            <br> <br><br>
            <!-- TITULO  DE LA PAGINA -->
            <v-layout text-center wrap>
                <v-flex>
                    <h1>ESTUDIO SOCIOECONOMICO</h1>
                </v-flex>                
            </v-layout>
            <!-- FIN DEL TITULO DE LA PAGINA -->

            <!-- INICIO DEL ENCABEZADO DE LA TABLA Y LOS COMPONENTES DEL BOTON REGISTRO NUEVO Y BUSCAR REGISTRO    -->
            <v-toolbar flat dark color="#2c2e3f"> 
                <v-toolbar-title>REGISTROS</v-toolbar-title>
                <v-divider class="mx-4"  vertical></v-divider>
                <div class="flex-grow-1"></div>
                <v-text-field color="white" v-model="search" label="BUSCAR REGISTRO ESTUDIO SOCIOECONOMICO" append-icon="search" single-line hide-details></v-text-field>                        
                <v-btn color="indigo" fab title="NUEVO ESTUDIO SOCIOECONOMICO" class="mx-2" dark @click="AbrirModalNuevoEstudio()">
                    <v-icon>add</v-icon>
                </v-btn>
            </v-toolbar>
            <!-- FIN DEL ENCABEZADO DE LA TABLA -->
            <!-- INICIO DE LA TABLA QUE CONTENDRA LOS REGISTROS DE ESTUDIOS SOCIOECONOMICOS -->
            <v-data-table
            :headers="TableHeaderES"
            :items="DataTableES"
            :search="search"
            class="elevation-1"
            >
                <template v-slot:item.action="{item}">
                    <v-icon small class="mr-2" title="EDITAR REGISTRO DE ESTUDIO SOCIOECONOMICO" @click="editItem(item)">edit</v-icon>
                </template>
            </v-data-table>
            <!-- FIN DE LA TABLA DE REGISTROS -->
        </v-container>
    </div>
</template>

<script>
export default ({
    data: () => ({    
        //declaracin de la variable para realizar los pasos para el llenado de formulario de nuevos registros de estudios socioeconomicos
        PasosDeFormulario: 0,
        //dialogo del nuevo registros socioeconomicos
        DialogoNuevoES: false,
        // REGLAS PARA VALIDAR LOS CAMPOS DE TEXTOS
        valid: false,
        nameRules: [
            v => !!v || 'Dato Requerido',
        ],
        // DECLARAMSO LA VARIABLE QUE HARA LA BUSQUEDA EN LA TABLA
        search: '',
        //SEXO
        itemsexo: ['MASCULINO', 'FEMENINO'],

        // AQUI DECLARAMOS LAS VARIABLES PARA OBTENER LA FECHA DE FECHA DE INGRESO
        modaldatefechaingreso: false,
        // AQUI DECLARAMOS LAS VARIABLES PARA OBTENER LA FECHA DE FECHA DE ENTREVISTA
        modaldatefechaentrevista: false,
        // AQUI DECLARAMOS LAS VARIABLES PARA OBTENER LA FECHA DE FECHA DE NACIMIENTO
        modaldatefechanacimiento: false,

        // AQUI SE DEFINEN LOS DATOS DEL ENCABEZADO DE LA TABLA DE REGISTROS MEDICOS
        TableHeaderES:[
            { text: 'REG. MEDICO NO.', value: 'RegMedicoNo'},
            { text: 'REG. SOCIAL NO.', value: 'RegSocialNo'},
            { text: 'FECHA DE INGRESO', value: 'datefechaingreso'},
            { text: 'FECHA DE ENTREVISTA', value: 'datefechaentrevista'},
            { text: 'T.S. ENTREVISTO', value: 'TSEntrevisto'},
            { text: 'Accion', value: 'action', sortable: false}
        ],
        // EL ARREGLO DEL CUERPO DE LA TABLA
        DataTableES: [],
        editedIndex: -1,
        editedItem: {
            RegMedicoNo: '',
            RegSocialNo: '',
            datefechaingreso: new Date().toISOString().substr(0, 10),
            datefechaentrevista: new Date().toISOString().substr(0, 10),
            TSEntrevisto: '',
            evaluo: '',
            NombreUsuario: '',
            escolaridad: '',
            direccion: '',
            telefono: '',
            permanente: '',
            temporal: '',
            edad: '',
            sexo: '',
            lugarnacimiento: '',
            datefechanacimiento: new Date().toISOString().substr(0, 10),
            atendidopor: '',
            religion: '',
            medico: '',
            servicio: '',
            ft: '',
            piscina: '',
            to: '',
            ti: '',
            ee: '',
            escuela: '',
            psicol: '',
            indcasa: '',
            motivosolicitud: '',
        },

        defaultItem: {
            RegMedicoNo: '',
            RegSocialNo: '',
            datefechaingreso: new Date().toISOString().substr(0, 10),
            datefechaentrevista: new Date().toISOString().substr(0, 10),
            TSEntrevisto: '',
            evaluo: '',
        },

}),

    computed: {
        formtitle(){
            return this.editedIndex === -1 ? 'NUEVO REGISTRO ESTUDIO SOCIOECONOMICO':'EDITAR REGISTRO ESTUDIO SOCIOECONOMICO'
        }
    },

    watch: {
        DialogoNuevoES (val){
            val || this.cerrarModalNuevoES()
        },
    },

    created() {
        this.initialize()
    },

    methods: {
        //cerramos el dialogo de nuevo registro de estudio socioeconomico
        CancelarDialogoRegistro(){
            this.DialogoNuevoES = false
        },

        //abrimos el dialogo para un nuevo registro de estudio socioeconomico
        AbrirModalNuevoEstudio(){
            this.DialogoNuevoES=true
        },

        //realizamos el primer paso para el registro de estudio socioeconomico
        IrPaso1(){
            this.PasosDeFormulario = 1
        },

        //realizamos el segundo paso para el registro de estudio socioeconomico
        IrPaso2 (){
            this.PasosDeFormulario = 2
        },
        //realizamos el tercer paso para el registro de estudio socioeconomico
        IrPaso3 (){
            this.PasosDeFormulario = 3
        },
        //realizamos el cuarto paso para el registro de estudio socioeconomico
        IrPaso4 (){
            this.PasosDeFormulario = 4
        },
        //realizamos el quinto paso para el registro de estudio socioeconomico
        IrPaso5 (){
            this.PasosDeFormulario = 5
        },

        initialize (){
            this.DataTableES = [
                {
                    RegMedicoNo: '101',
                    RegSocialNo: '109',
                    datefechaingreso: '2019-09-13',
                    datefechaentrevista: '2019-09-14',
                    TSEntrevisto: 'CHINO'
                }
            ]
        },

        editItem (item) {
            this.editedIndex = this.DataTableES.indexOf(item)
            this.editedItem = Object.assign({}, item)
            this.DialogoNuevoES = true
        },

        cerrarModalNuevoES () {
            this.DialogoNuevoES = false
            setTimeout(() => {
                this.editedItem = Object.assign({}, this.defaultItem)
                this.editedIndex = -1
            },
            300
            )
        },

        guardarNuevoES () {
            if (this.editedIndex > -1){
                Object.assign(this.DataTableES[this.editedIndex], this.editedItem)
            }
            else
            {
                this.DataTableES.push(this.editedItem)
            }
            this.cerrarModalNuevoES()
        },        
    },
})
</script>
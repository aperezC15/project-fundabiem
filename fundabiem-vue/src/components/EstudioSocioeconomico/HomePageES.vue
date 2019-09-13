<template>
    <div>
        <v-container>            
            <br> <br><br>
            <v-layout text-center wrap>
                <v-flex>
                    <h1>ESTUDIO SOCIOECONOMICO</h1>
                </v-flex>                
            </v-layout>

            <v-data-table
            :headers="TableHeaderES"
            :items="DataTableES"
            :search="search"
            class="elevation-1"
            >
                <template v-slot:top>
                    <v-toolbar flat dark color="#2c2e3f"> 
                        <v-toolbar-title>REGISTROS</v-toolbar-title>
                        <v-divider class="mx-4"  vertical></v-divider>
                        <div class="flex-grow-1"></div>

                        <!-- AQUI INICIAMOS EL DIALOGO QUE CONTENDRA EL FORMULARIO DEL ESTUDIO SOCIOECONOMICO -->
                        <v-dialog v-model="DialogoNuevoES" persistent max-width="900px">
                            <template v-slot:activator="{on}">
                                <v-btn color="indigo" fab title="NUEVO ESTUDIO SOCIOECONOMICO" class="mx-2" dark v-on="on">
                                    <v-icon>add</v-icon>
                                </v-btn>
                                <v-text-field color="white" v-model="search" label="BUSCAR REGISTRO ESTUDIO SOCIOECONOMICO" append-icon="search" single-line hide-details></v-text-field>                        
                            </template>
                            <v-card >
                                <v-card-title>
                                    <span class="headline"> {{formtitle}}</span>
                                </v-card-title>
                                <v-card-text>
                                    <v-form v-model="valid">
                                        <v-container>
                                            <v-divider></v-divider>
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
                                                            v-model="datefechaingreso"
                                                            label="Fecha de Ingreso"
                                                            prepend-icon="event"
                                                            readonly
                                                            v-on="on"
                                                        ></v-text-field>
                                                        </template>
                                                        <v-date-picker v-model="datefechaingreso" color="#2c2e3f" scrollable>
                                                        <div class="flex-grow-1"></div>
                                                        <v-btn text color="primary" @click="modaldatefechaingreso = false">CANCELAR</v-btn>
                                                        <v-btn text color="primary" @click="$refs.dialog.save(datefechaingreso)">OK</v-btn>
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
                                                            v-model="datefechaentrevista"
                                                            label="FECHA DE ENTREVISTA"
                                                            prepend-icon="event"
                                                            readonly
                                                            v-on="on"
                                                        ></v-text-field>
                                                        </template>
                                                        <v-date-picker v-model="datefechaentrevista" color="#2c2e3f" scrollable>
                                                        <div class="flex-grow-1"></div>
                                                        <v-btn text color="primary" @click="modaldatefechaentrevista = false">CANCELAR</v-btn>
                                                        <v-btn text color="primary" @click="$refs.dialog2.save(datefechaentrevista)">OK</v-btn>
                                                        </v-date-picker>
                                                    </v-dialog>
                                                </v-col>
                                            </v-row>
                                        </v-container>
                                    </v-form>
                                </v-card-text>
                                <v-card-actions>
                                    <div class="flex-grow-1"></div>
                                    <v-btn color="indigo" text @click="cerrarModalNuevoES">CERRAR</v-btn>
                                    <v-btn color="indigo" text @click="guardarNuevoES">GUARDAR ESTUDIO SOCIOECONOMICO</v-btn>
                                </v-card-actions>
                            </v-card>
                        </v-dialog>
                    </v-toolbar>
                </template>

            </v-data-table>
        </v-container>
    </div>
</template>

<script>
export default ({
    data: () => ({    
        DialogoNuevoES: false,
        // REGLAS PARA VALIDAR LOS CAMPOS DE TEXTOS
        valid: false,
        nameRules: [
            v => !!v || 'Dato Requerido',
        ],
        // DECLARAMSO LA VARIABLE QUE HARA LA BUSQUEDA EN LA TABLA
        search: '',

        // AQUI DECLARAMOS LAS VARIABLES PARA OBTENER LA FECHA DE FECHA DE INGRESO
        datefechaingreso: new Date().toISOString().substr(0, 10),
        modaldatefechaingreso: false,
        // AQUI DECLARAMOS LAS VARIABLES PARA OBTENER LA FECHA DE FECHA DE ENTREVISTA
        datefechaentrevista: new Date().toISOString().substr(0, 10),
        modaldatefechaentrevista: false,

        // AQUI SE DEFINEN LOS DATOS DEL ENCABEZADO DE LA TABLA DE REGISTROS MEDICOS
        TableHeaderES:[
            { text: '1er. APELLIDO', value: 'apellido1DataTableRM'},
            { text: '2do. APELLIDO', value: 'apellido2DataTableRM'},
            { text: '1er. NOMBRE', value: 'name1DataTableRM'},
            { text: '2do. NOMBRE', value: 'name2DataTableRM'},
            { text: 'His. Clínica', value: 'clinicaDataTableRM'},
            { text: 'Accion', value: 'action', sortable: false}
        ],
        // EL ARREGLO DEL CUERPO DE LA TABLA
        DataTableES: [],
        editedIndex: -1,
        editedItem: {

        },

        defaultItem: {

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
        initialize (){
            this.DataTableES = [
                {
                    // apellido1DataTableRM: 'Herrera',
                    // apellido2DataTableRM: 'Vasquez',
                    // name1DataTableRM: 'Mario',
                    // name2DataTableRM: 'David',
                    // clinicaDataTableRM: 'No sé',
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
<template>
    <v-container app> <br><br>
        <!-- TITULO DE LA PAGINA  -->
        <v-layout text-center wrap >
            <v-flex mb-4>
            <h1>DEPARTAMENTO REGISTROS MEDICOS</h1>
            </v-flex>
        </v-layout>

        <!-- AQUI INICIA LA ESTRUCTURA DE LA TABLA -->
        <v-data-table 
        :headers="TableHeaderRM"
        :items="DataTableRM"
        :search="search"
        class="elevation-1"
        >            
            <template v-slot:top>               
                <!-- ENCABEZADO DE LA TABLA DE REGISTROS  -->
                <v-toolbar flat color="white">
                    <v-toolbar-title>REGISTROS</v-toolbar-title>
                    
                    <v-divider class="mx-4" inset vertical></v-divider>
                    <div class="flex-grow-1"></div>
                    <!-- ESTRUCTURA DEL DIALOGO PARA LLENAR EL FORMULARIO -->
                    <v-dialog v-model="DiagoloNuevoRM" persistent max-width="900px">                        
                        <template v-slot:activator="{on}">    
                            <v-btn color="indigo" title="NUEVO REGISTRO MEDICO" fab dark class="mx-2" v-on="on">
                                <v-icon>add</v-icon>
                            </v-btn>
                            <v-text-field height="50px" color="#2c2e3f" v-model="search" label="BUSCAR REGISTRO MEDICO" append-icon="search" single-line hide-details></v-text-field>                        
                        </template>
                        <v-card>
                            <v-card-title>
                                <span class="headline">{{ formtitle}}</span>
                            </v-card-title>
                            <v-card-text>
                                <v-form v-model="valid"> 
                                    <v-container>
                                        <v-divider></v-divider>
                                        <v-row>
                                            <v-col cols="12" sm="6" md="3">
                                                <v-text-field v-model="editedItem.apellido1DataTableRM" label="1er. APELLIDO" :rules="nameRules" required></v-text-field>
                                            </v-col>
                                            <v-col cols="12" sm="6" md="3">
                                                <v-text-field v-model="editedItem.apellido2DataTableRM" label="2do. APELLIDO" :rules="nameRules" required></v-text-field>
                                            </v-col>
                                            <v-col cols="12" sm="6" md="2">
                                                <v-text-field v-model="editedItem.name1DataTableRM" label="1er. NOMBRE" :rules="nameRules" required></v-text-field>
                                            </v-col>
                                            <v-col cols="12" sm="6" md="2">
                                                <v-text-field v-model="editedItem.name2DataTableRM" label="2d. NOMBRE" :rules="nameRules" required></v-text-field>
                                            </v-col>
                                            <v-col cols="12" sm="6" md="2">
                                                <v-text-field v-model="editedItem.clinicaDataTableRM" label="His. Clínica" :rules="nameRules" required></v-text-field>
                                            </v-col>                                                                                    
                                        </v-row>
                                    </v-container>
                                    <v-container>
                                        <v-divider></v-divider>
                                        <v-row>
                                            <v-col class="d-flex" cols="12" sm="6" md="2">
                                                <v-select v-model="editedItem.sexoDataTableRM" :items="itemsexo" label="SEXO" :rules="nameRules" required></v-select>
                                            </v-col>                                                                                    
                                            <v-col cols="12" sm="6" md="2">
                                                <v-text-field v-model="editedItem.edadDataTableRM" label="EDAD" :rules="nameRules" required></v-text-field>
                                            </v-col>
                                            <v-col cols="12" ms="6" md="3">
                                                <v-dialog
                                                    ref="dialog"
                                                    v-model="modaldate"
                                                    return-value.sync="date"
                                                    persistent
                                                    width="290px"
                                                >
                                                    <template v-slot:activator="{ on }">
                                                    <v-text-field
                                                        v-model="date"
                                                        label="Fecha Nacimiento"
                                                        prepend-icon="event"
                                                        readonly
                                                        v-on="on"
                                                    ></v-text-field>
                                                    </template>
                                                    <v-date-picker v-model="date" color="#2c2e3f" scrollable>
                                                    <div class="flex-grow-1"></div>
                                                    <v-btn text color="primary" @click="modaldate = false">CANCELAR</v-btn>
                                                    <v-btn text color="primary" @click="$refs.dialog.save(date)">OK</v-btn>
                                                    </v-date-picker>
                                                </v-dialog>
                                            </v-col>
                                            <v-col cols="12" ms="6" md="3">
                                                <v-text-field v-model="editedItem.tecnicoDataTableRM" label="GRUPO TECNICO" :rules="nameRules" required></v-text-field>
                                            </v-col>                              
                                            <v-col cols="12" ms="6" md="2">
                                                <v-text-field v-model="editedItem.otrosDataTableRM" label="OTROS"></v-text-field>
                                            </v-col>                                                                                          
                                        </v-row>
                                    </v-container>
                                    <v-container>
                                        <v-divider></v-divider>
                                        <v-row>
                                            <v-col cols="12" ms="6" md="6">
                                                <v-text-field v-model="editedItem.direccionDataTableRM" label="DIRECCION" :rules="nameRules" required></v-text-field>
                                            </v-col>
                                            <v-col cols="12" ms="6" md="6">
                                                <v-text-field v-model="editedItem.departamentoDataTableRM" label="DEPARTAMENTO" :rules="nameRules" required ></v-text-field>
                                            </v-col>
                                        </v-row>
                                    </v-container>
                                    <v-container>
                                        <v-divider></v-divider>
                                        <v-row>
                                            <v-col cols="12" ms="6" md="3">
                                                <v-text-field v-model="editedItem.residenciaDataTableRM" label="RESIDENCIA HABITUAL" :rules="nameRules" required></v-text-field>
                                            </v-col>
                                            <v-col cols="12" ms="6" md="3">
                                                <v-text-field v-model="editedItem.ciudadDataTableRM" label="CIUDAD" :rules="nameRules" required></v-text-field>
                                            </v-col>
                                            <v-col cols="12" ms="6" md="3">
                                                <v-text-field v-model="editedItem.departamento2DataTableRM" label="DEPARTAMENTO" :rules="nameRules" required></v-text-field>
                                            </v-col>
                                            <v-col cols="12" ms="6" md="3">
                                                <v-text-field v-model="editedItem.paisDataTableRM" label="PAIS" :rules="nameRules" required></v-text-field>
                                            </v-col>
                                        </v-row>
                                    </v-container>
                                    <v-container>
                                        <v-divider></v-divider>
                                        <v-row>
                                            <v-col cols="12" ms="6" md="6">
                                                <v-text-field v-model="editedItem.residencia2DataTableRM" label="RESIDENCIA HABITUAL" :rules="nameRules" required></v-text-field>
                                            </v-col>
                                            <v-col cols="12" ms="6" md="6">
                                                <v-text-field v-model="editedItem.lugarDataTableRM" label="LUGAR" :rules="nameRules" required></v-text-field>
                                            </v-col>
                                        </v-row>
                                    </v-container>
                                    <v-container>
                                        <v-divider></v-divider>
                                        <v-row>
                                            <v-col cols="12" ms="6" md="6">
                                                <v-text-field v-model="editedItem.padreDataTableRM" label="PADRE" :rules="nameRules" required></v-text-field>
                                            </v-col>
                                            <v-col cols="12" ms="6" md="6">
                                                <v-text-field v-model="editedItem.madreDataTableRM" label="MADRE" :rules="nameRules" required></v-text-field>
                                            </v-col>
                                        </v-row>
                                    </v-container>
                                    <v-container>
                                        <v-divider></v-divider>
                                        <v-row>
                                            <v-col cols="12" ms="6" md="4">
                                                <v-text-field v-model="editedItem.encargadoDataTableRM" label="PERSONA ENCARGADA" :rules="nameRules" required></v-text-field>
                                            </v-col>
                                            <v-col cols="12" ms="6" md="4">
                                                <v-text-field v-model="editedItem.direccion2DataTableRM" label="DIRECCION" :rules="nameRules" required></v-text-field>
                                            </v-col>
                                            <v-col cols="12" ms="6" md="4">
                                                <v-text-field v-model="editedItem.telefonoDataTableRM" label="TELEFONO" :rules="nameRules" required></v-text-field>
                                            </v-col>
                                        </v-row>
                                    </v-container>
                                    <v-container>
                                        <v-divider></v-divider>
                                        <v-row>
                                            <v-col cols="12" ms="6" md="6">
                                                <v-dialog
                                                    ref="dialog2"
                                                    v-model="modaldate2"
                                                    return-value.sync="date2"
                                                    persistent
                                                    width="290px"
                                                >
                                                    <template v-slot:activator="{ on }">
                                                    <v-text-field
                                                        v-model="date2"
                                                        label="FECHA Y HORA DE ADMISION"
                                                        prepend-icon="event"
                                                        readonly
                                                        v-on="on"
                                                    ></v-text-field>
                                                    </template>
                                                    <v-date-picker v-model="date2" color="#2c2e3f" scrollable>
                                                    <div class="flex-grow-1"></div>
                                                    <v-btn text color="primary" @click="modaldate2 = false">CANCELAR</v-btn>
                                                    <v-btn text color="primary" @click="$refs.dialog2.save(date2)">OK</v-btn>
                                                    </v-date-picker>
                                                </v-dialog>
                                            </v-col>
                                            <v-col cols="12" ms="6" md="6">
                                                <v-text-field v-model="editedItem.firmaDataTableRM" label="FIRMA" :rules="nameRules" required></v-text-field>
                                            </v-col>
                                        </v-row>
                                    </v-container>
                                    <v-container>
                                        <v-divider></v-divider>
                                        <v-row>
                                            <v-textarea autocomplete="diagnostico" v-model="editedItem.diagnosticoDataTableRM" label="DIAGNOSTICO FINAL"></v-textarea>                                            
                                        </v-row>
                                    </v-container>
                                    <v-container>
                                        <v-divider></v-divider>
                                        <v-row>
                                            <v-textarea v-model="editedItem.recomendacionesDataTableRM" autocomplete="recomendaciones" label="RECOMENDACIONES"></v-textarea>
                                        </v-row>
                                    </v-container>
                                </v-form>
                            </v-card-text>
                            <v-card-actions>
                                <div class="flex-grow-1"></div>
                                <v-btn color="indigo" text @click="cerrarmodalNuevoRM">CERRAR</v-btn>
                                <v-btn color="indigo" text @click="guardarNuevoRM">GUARDAR REGISTRO</v-btn>
                            </v-card-actions>
                        </v-card>
                    </v-dialog>
                </v-toolbar>                    
            </template>
            <template v-slot:item.action="{ item }">
                <v-icon small class="mr-2" title="EDITAR REGISTRO MEDICO" @click="editItem(item)">edit</v-icon>
            </template>
            <template v-slot:no-results>        
                <v-alert type="error">EL REGISTRO "{{search}}" NO SE ENCUENTRA EN LA BASE DE DATOS</v-alert>            
            </template>
        </v-data-table>
    </v-container>
</template>

<script>
import { __values } from 'tslib';

export default({
    data: () => ({
    
        DiagoloNuevoRM: false,
        valid: false,

        nameRules: [
            v => !!v || 'Dato Requerido',
        ],
    // CALENDARIO FECHA DE NACIMIENTO
    date: new Date().toISOString().substr(0, 10),
    modaldate: false,
    // CALENDARIO DE FECHA Y HORA DE ADMISION
    date2: new Date().toISOString().substr(0, 10),
    modaldate2: false,
    // AQUI SELECCIONAMOS EL SEXO DEL USUARIO
    itemsexo: ['M', 'F'],
    // DECLARAMSO LA VARIABLE QUE HARA LA BUSQUEDA EN LA TABLA
    search: '',
    // AQUI SE DEFINEN LOS DATOS DEL ENCABEZADO DE LA TABLA DE REGISTROS MEDICOS
    TableHeaderRM:[
        { text: '1er. APELLIDO', value: 'apellido1DataTableRM'},
        { text: '2do. APELLIDO', value: 'apellido2DataTableRM'},
        { text: '1er. NOMBRE', value: 'name1DataTableRM'},
        { text: '2do. NOMBRE', value: 'name2DataTableRM'},
        { text: 'His. Clínica', value: 'clinicaDataTableRM'},
        { text: 'Accion', value: 'action', sortable: false}
    ],
        DataTableRM: [],
        editedIndex: -1,
        editedItem: {
            apellido1DataTableRM: '',
            apellido2DataTableRM: '',
            name1DataTableRM: '',
            name2DataTableRM: '',
            clinicaDataTableRM: '',
            sexoDataTableRM: '',
            edadDataTableRM: '',
            date: '',
            tecnicoDataTableRM: '',
            otrosDataTableRM: '',
            direccionDataTableRM: '',
            departamentoDataTableRM: '',
            residenciaDataTableRM: '',
            ciudadDataTableRM: '' ,
            departamento2DataTableRM: '',
            paisDataTableRM: '',
            residencia2DataTableRM: '',
            lugarDataTableRM: '',
            padreDataTableRM: '',
            madreDataTableRM: '',
            encargadoDataTableRM: '',
            direccion2DataTableRM: '',
            telefonoDataTableRM: '',
            date2: '',
            firmaDataTableRM: '',
            diagnosticoDataTableRM: '',
            recomendaciones: '',
        },
        
        defaultItem: {
            apellido1DataTableRM: '',
            apellido2DataTableRM: '',
            name1DataTableRM: '',
            name2DataTableRM: '',
            clinicaDataTableRM: '',
            sexoDataTableRM: '',
            edadDataTableRM: '',
            date: '',
            tecnicoDataTableRM: '',
            otrosDataTableRM: '',
            direccionDataTableRM: '',
            departamentoDataTableRM: '',
            residenciaDataTableRM: '',
            ciudadDataTableRM: '' ,
            departamento2DataTableRM: '',
            paisDataTableRM: '',
            residencia2DataTableRM: '',
            lugarDataTableRM: '',
            padreDataTableRM: '',
            madreDataTableRM: '',
            encargadoDataTableRM: '',
            direccion2DataTableRM: '',
            telefonoDataTableRM: '',
            date2: '',
            firmaDataTableRM: '',
            diagnosticoDataTableRM: '',
            recomendaciones: '',
        },
}),

    computed: {
        formtitle (){
            return this.editedIndex === -1 ? 'NUEVO REGISTRO MEDICO' : 'EDITAR REGISTRO MEDICO'
        }
    },

    watch: {
        DiagoloNuevoRM (val){
            val || this.cerrarmodalNuevoRM()
        },
    },

    created() {
        this.initialize()
    },

    methods: {
        initialize (){
            this.DataTableRM = [
                {
                    apellido1DataTableRM: 'Herrera',
                    apellido2DataTableRM: 'Vasquez',
                    name1DataTableRM: 'Mario',
                    name2DataTableRM: 'David',
                    clinicaDataTableRM: 'No sé',
                }
            ]
        },

        editItem (item) {
            this.editedIndex = this.DataTableRM.indexOf(item)
            this.editedItem = Object.assign({}, item)
            this.DiagoloNuevoRM = true
        },

        cerrarmodalNuevoRM () {
            this.DiagoloNuevoRM = false
            setTimeout(() => {
                this.editedItem = Object.assign({}, this.defaultItem)
                this.editedIndex = -1
            },
            300
            )
        },

        guardarNuevoRM () {
            if (this.editedIndex > -1){
                Object.assign(this.DataTableRM[this.editedIndex], this.editedItem)
            }
            else
            {
                this.DataTableRM.push(this.editedItem)
            }
            this.cerrarmodalNuevoRM()
        },
    },
})

</script>
<template>
    <v-container>
        <!-- AQUI MANDAMOS LOS PARAMETROS PARA ABRIR Y CERRAR EL MODAL -->
        <!--variables de datos del formulario @variables = "editedItem" -->
        <ModalHistoriaClinicaPsicologia
            @close-modal-historia-psicologica = "CerrarDialogoHistoriaPsicologica"
            @variables = "editedItem"
            @Save-Historia-Psicologica = "SaveHistoriaPsicologica"
            :ModalHistoriaPsicologica = "DialogoHistoriaPsicologicaHP"
            :ModalTitle = "FormTitle"
        />
        
        <!-- TITULO DE LA PAGINA DE HISTORIA CLINICA PSICOLOGIA -->
        <v-layout text-center wrap>
            <v-flex>
                <h1>HISTORIA CLINICA PSICOLOGIA</h1>
            </v-flex>
        </v-layout>            

        <!-- ENCABEZADO DE LA TABLA Y LOS COMPONENTES DEL BOTON REGISTRO NUEVO Y BUSCAR REGISTRO -->
        <v-toolbar flat dark color="#2c2e3f">
            <v-toolbar-title>REGISTROS</v-toolbar-title>
            <v-divider class="mx-4" inset vertical></v-divider>
            <div class="flex-grow-1"></div>

            <v-text-field class="mx-2" color="white" v-model="Search_Historia_Psicologica" label="BUSCAR REGISTRO DE HISTORIA CLINICA PSICOLOGIA" append-icon="search" single-line hide-details></v-text-field>
            <v-btn color="indigo" title="NUEVO REGISTRO HISTORIA CLINICA PSICOLOGICA" @click="OpenDialogoHistoriaPsicologica()" fab dark class="mx-2">
                <v-icon>add</v-icon>
            </v-btn>
        </v-toolbar>
        <!-- FIN DEL ENCABEZADO DE LA TABLA -->

        <!-- INICIO DE LA TABLA PRINCIPAL -->
        <v-data-table 
        :headers= "HeaderTablePsicologia"
        :items= "DataTablePsicologia"
        :search= "Search_Historia_Psicologica"
        class="elevation-10"
        >
            <!-- APARTADO PARA AGREGAR LAS ACCIONES DE CADA REGISTRO EN LA TABLA -->
            <template v-slot:item.action="{ item }">
                <div class="text-right">
                    <v-btn class="mx-2" rounded dark color="#2c2e3f" title="EDITAR REGISTRO DE HISTORIA CLINICA PSICOLOGICA">
                        <v-icon small left>edit</v-icon> EDITAR
                    </v-btn>
                </div>
            </template>
            <!-- MOSTRAMOS UN MENSAJE DE ERRROR CUANDO LA BUSQUEDA REALIZADA NO ESTE EN LA BASE DE DATOS -->
            <template v-slot:no-results>
                <v-alert type="error">EL REGISTRO {{ Search_Historia_Psicologica }} NO SE ENCUENTRA REGISTRADO</v-alert>
            </template>
        </v-data-table>
        <!-- FIN DE LA TABLA PRINCIPAL -->
    </v-container>
</template>

<script>
import { __values } from 'tslib';
import ModalHistoriaClinicaPsicologia from './ModalHistoriaClinicaPsicologia.vue'

export default {
    components: {
        ModalHistoriaClinicaPsicologia
    },

    data: () => ({
        DialogoHistoriaPsicologicaHP: false,

        // VARIABLE PARA LA BUSQUEDA DE UN REGISTRO DE HISTORIA CLINICA PSICOLOGICA
        Search_Historia_Psicologica:  '',

        // ENCABEZADO DEL CUERPO DE LA TABLA DE HISTORIA CLINICA PSICOLOGICA
        HeaderTablePsicologia: [
            {text: 'NOMBRE', value: 'NombreHP', align: 'center'},
            {text: 'SEXO', value: 'SexoHP', align: 'center'},
            {text: 'EDAD', value: 'EdadHP', align: 'center'},
            {text: 'ESTUDIOS', value: 'EstudiosHP', align: 'center'},
            {text: 'ORIGEN Y PROCEDENCIA', value: 'OrigenHP', align: 'center'},
            {text: 'OCUPACION', value: 'OcupacionHP', align: 'center'},
            {text: 'ACCION', value: 'action', align: 'center', sortable: false},
        ],
        // DECLARAMOS EL ARRAY QUE CONTENDRA LA INFORMACION DE LOS REGISTROS 
        DataTablePsicologia: [],
        editedIndex: -1,
        // DECLARAMOS LAS VARIABLES DE ENTRADA DE NUESTRO FORMULARIO 
        editedItem: {
            // DATOS GENERALES
            NombreHP: '',
            SexoHP: '',
            EdadHP: '',
            EstudiosHP: '',
            OrigenHP: '',
            OcupacionHP: '',
            EstadoCivilHP: '',
            ReligionHP: '',
            ProgenitorHP: '',
            // MOTIVO DE LA CONSULTA
            MotivoConsultaHP: '',
            // ANTECEDENTES DEL PACIENTE
            AntecedentesPacienteHP: '',
            // PERFIL SOCIAL
            PerfilSocialHP: '',
            // PESONALIDAD
            PersonalidadHP: '',
            // EXAMEN MENTAL
            AparienciaGeneralHP: '',
            EstadoConcienciaHP: '',
            EstadoAnimoHP: '',
            ActividadMotoraHP: '',
            AsociacionHP: '',
            ContenidoIdeasHP: '',
            SensoriumHP: '',
            MemoriaHP: '',
            PensamientoHP: '',
            ResultadoHP: '',
            // DATOS RELEVANTES SOBRE LA FAMILIA DEL PACIENTE
            DatosRelevantesHP: '',
            // DIAGNOSTICO
            DiagnosticoHP: '',
            // PLAN DE ORIENTACION PSICOLOGICA
            PlanOrientacionHP: '',
        },

        defaultItem: {
            // DATOS GENERALES
            NombreHP: '',
            SexoHP: '',
            EdadHP: '',
            EstudiosHP: '',
            OrigenHP: '',
            OcupacionHP: '',
            EstadoCivilHP: '',
            ReligionHP: '',
            ProgenitorHP: '',
            // MOTIVO DE LA CONSULTA
            MotivoConsultaHP: '',
            // ANTECEDENTES DEL PACIENTE
            AntecedentesPacienteHP: '',
            // PERFIL SOCIAL
            PerfilSocialHP: '',
            // PESONALIDAD
            PersonalidadHP: '',
            // EXAMEN MENTAL
            AparienciaGeneralHP: '',
            EstadoConcienciaHP: '',
            EstadoAnimoHP: '',
            ActividadMotoraHP: '',
            AsociacionHP: '',
            ContenidoIdeasHP: '',
            SensoriumHP: '',
            MemoriaHP: '',
            PensamientoHP: '',
            ResultadoHP: '',
            // DATOS RELEVANTES SOBRE LA FAMILIA DEL PACIENTE
            DatosRelevantesHP: '',
            // DIAGNOSTICO
            DiagnosticoHP: '',
            // PLAN DE ORIENTACION PSICOLOGICA
            PlanOrientacionHP: '',
        },
    }),

    computed: {
        FormTitle(){
            return this.editedIndex === -1 ? 'NUEVO REGISTRO DE HISTORIA CLINICA PSICOLOGICA':' EDITAR REGISTRO DE HISTORIA CLINICA PSICOLOGICA'
        }
    },

    watch: {

    },

    created() {
        this.initialize()
    },

    // metodos de la pagina
    methods: {
        initialize(){
            this.DataTablePsicologia = [
                {
                    NombreHP: 'Yesli Alejandra Tepe',
                    SexoHP: 'Femenino',
                    EdadHP: '22',
                    EstudiosHP: 'Profesorado en Educacion',
                    OrigenHP: 'no se',
                    OcupacionHP: 'no se',
                }
            ]
        },

        OpenDialogoHistoriaPsicologica(){
            this.DialogoHistoriaPsicologicaHP = true
        },

        CerrarDialogoHistoriaPsicologica(){     
            this.$swal.fire({
                title: '¿Está seguro que quiere Salir?',
                text: "¡Perdera la información ingresada del Paciente!",
                type: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: '¡Sí, Salir del Registro!',
                cancelButtonText: 'Cancelar'
            }).then((result) => {
                if (result.value) {
                    this.$swal.fire(
                        '¡Cancelado!',
                        'El Ingreso del Paciente ha sido Cancelado',
                        'success'
                    )                
                    this.DialogoHistoriaPsicologicaHP =  false
                    }
            })        
        },

        SaveHistoriaPsicologica () {
            if (this.editedIndex > -1){
                Object.assign(this.DataTablePsicologia [this.editedIndex], this.editedItem)
            }
            else
            {
                this.DataTablePsicologia.push(this.editedItem)
            }
            this.DialogoHistoriaPsicologicaHP =  false
        },
    }
}
</script>
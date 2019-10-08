<template>
    <div>
        <v-dialog v-model="DialogoHistoriaPsicologica" fullscreen hide-overlay transition="dialog-bottom-transition">

        </v-dialog>
    </div>
</template>

<script>
export default {
    props: ['DialogoHistoriaPsicologicaHP'], 

    data() {

    },

    computed: {
        DialogoHistoriaPsicologica: {
            get: function(){
                return this.dialogoHistoriaPsicologicaHP    
            }
        }
    },

    methods: {
        CerrarModalHistoriaPsicologica(){
            this.$emit('cerrar-modal-HistoriaPsicologicaHP')
        }
    },
}
</script>
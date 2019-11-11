<template>
  <v-container fluid>
    <v-row>
      <v-col cols="6">
        <v-carousel 
              cycle              
              show-arrows-on-hover
        >
            <v-carousel-item 
                v-for="(images, i) in imagefunda"
                :key="i"
                :src="images.src"
                transition="scale-transition" reverse-transition="scale-transition" origin="center center"
            >
            </v-carousel-item>
        </v-carousel>
      </v-col>
      <v-col cols="6">
        <v-row align="center" justify="center">
          <v-col cols="6">
            <v-card class="elevation-10"> 
              <v-img 
                src="img/teleton.jpg"
                max-width="355"
                max-height="300"          
              >            
              </v-img>
            </v-card>
          </v-col>
          <v-col cols="6">
            <v-img 
              src="https://get.mw.cr/c/aurens/content/images/colleges/logos/211.png"
              max-width="300"
              max-height="300"          
            >            
            </v-img>
          </v-col>
        </v-row> <br>
        <v-row>
          <v-expansion-panels popout dark>
            <v-expansion-panel
              v-for="(info,i) in infofunda" :key="i"
            >
              <v-expansion-panel-header>{{info.title}}</v-expansion-panel-header>
              <v-expansion-panel-content>
                <p>{{info.informacion}}</p> <br> 
              </v-expansion-panel-content>
            </v-expansion-panel>
          </v-expansion-panels>
        </v-row>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
  export default {
    data () {
      return {
        infofunda: [
          {
            title: 'MISION',
            informacion:  'Brindar de forma accesible y eficiente, servicios integrales de habilitación y rehabilitación a nivel nacional a personas con discapacidad física neuromusculoesquelética, para volverlas parte activa de una sociedad inclusiva, con una operación honesta y una administración responsable.'
          },
          {
            title:  'VISION',
            informacion:  'Ser referente a nivel mundial en el campo de emprendimiento social, siendo reconocidos por aplicar las mejores prácticas de gestión en el área médica, psicológica, financiera, administrativa, operativa y de recaudación.'
          },
          {
            title:  'VALORES',
            informacion: '1. Equidad - 2. Unión - 3. Coherencia - 4. Tolerancia - 5. Empatía - 6. Transparencia - 7. Vocación de Servicio y Compromiso al usuario - 8. Solidaridad - 9. Respeto'
          },
          {
            title:  'OBJETIVO',
            informacion: 'Proporcionar servicios de habilitación y rehabilitación integral a personas con discapacidad física.'
          },
        ],
        imagefunda: [
          {
            src:"img/fundabiem1.jpeg",
          },
          {
            src:"img/fundabiem2.jpeg",
          }
        ],
      }
    },
    created() {
      console.log('hola desde el homepage')
    },
  }
</script>
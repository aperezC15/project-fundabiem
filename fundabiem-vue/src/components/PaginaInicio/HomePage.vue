<template>
  <body>
    <v-carousel hide-delimiters>
      <v-carousel-item
        v-for="(item,i) in items"
        :key="i"
        :src="item.src"
      ></v-carousel-item>
    </v-carousel>
      <v-content>
        <div>
        <section>
          <v-layout>
            <v-flex xs12>
              <v-container grid-list-xl>
                <v-layout row wrap align-center>
                  <v-flex xs12 md4>
                    <v-card flat class="transparent">
                      <v-card-text class="text-center">
                        <v-icon x-large class="blue--text text--lighten-2">fas fa-power-off</v-icon>
                      </v-card-text>
                      <v-card-title primary-title class="layout justify-center">
                        <div class="headline text-center">MISION</div>
                      </v-card-title>
                      <v-card-text>
                        Brindar de forma accesible y eficiente, servicios integrales de habilitación y 
                        rehabilitación a nivel nacional a personas con discapacidad física neuromusculoesquelética, 
                        para volverlas parte activa de una sociedad inclusiva, con una operación honesta y una 
                        administración responsable.
                      </v-card-text>
                    </v-card>
                  </v-flex>
                  <v-flex xs12 md4>
                    <v-card flat class="transparent">
                      <v-card-text class="text-center">
                        <v-icon x-large class="blue--text text--lighten-2">fas fa-power-off</v-icon>
                      </v-card-text>
                      <v-card-title primary-title class="layout justify-center">
                        <div class="headline">VISION</div>
                      </v-card-title>
                      <v-card-text>
                        Ser referente a nivel mundial en el campo de emprendimiento social, siendo 
                        reconocidos por aplicar las mejores prácticas de gestión en el área médica, 
                        psicológica, financiera, administrativa, operativa y de recaudación.

                        Nuestras buenas prácticas nos permitirán atender para el 2030 a más de 30 mil
                        personas con discapacidad física neuromusculoesquelética, quienes serán atendidas
                        con los mismos estándares de calidad y tecnología en cualquiera de nuestros 
                        centros de atención.
                      </v-card-text>
                    </v-card>
                  </v-flex>
                  <v-flex xs12 md4>
                    <v-card flat class="transparent">
                      <v-card-text class="text-center">
                        <v-icon x-large class="blue--text text--lighten-2">fas fa-power-off</v-icon>
                      </v-card-text>
                      <v-card-title primary-title class="layout justify-center">
                        <div class="headline">OBJETIVOS</div>
                      </v-card-title>
                      <v-card-text>
                        Proporcionar servicios de habilitación y rehabilitación integral a personas
                        con discapacidad física.

                        >Brindar terapia para estimular, inhibir e incrementar la habilidad y 
                         coordinación, manteniendo o mejorando sus amplitudes articulares y fuerza muscular.
                        </v-card-text>
                        <v-card-text>
                        >Desarrollar la autonomía personal, a través del reforzamiento de área física, 
                         cognitiva, emocional y laboral.
                        </v-card-text>
                      </v-card-text>
                    </v-card>
                  </v-flex>
                </v-layout>
              </v-container>
            </v-flex>
          </v-layout>
        </section>
        </div>
      </v-content>
  </body>
</template>

<script>
  export default {
    data () {
      return {
        colors: [
          'indigo',
          'warning',
          'pink darken-2',
          'red lighten-1',
          'deep-purple accent-4',
        ],
        items: [
          {
            src: 'https://www.yovivoaje.com/wp-content/uploads/2018/06/cielo-teleton-equipo.png',
          },
          {
            src: 'https://cdn.vuetifyjs.com/images/carousel/sky.jpg',
          },
          {
            src: 'https://cdn.vuetifyjs.com/images/carousel/bird.jpg',
          },
          {
            src: 'https://cdn.vuetifyjs.com/images/carousel/planet.jpg',
          },
        ],
      }
    },
    created() {
      console.log('hola desde el homepage')
    },
  }
</script>
<template>
  <div>
    <v-form v-model="valid">
      <v-container>
        <v-row>
          <v-col cols="12">
            <v-textarea
              filled
              label="Diagnóstico social"
              rows="5"
            ></v-textarea>
          </v-col>
          <v-col cols="12">
            <v-textarea
              filled
              label="Opinión (TS)"
              rows="5"
            ></v-textarea>
          </v-col>
          <v-col cols="12">
            <v-textarea
              filled
              label="Observaciones"
              rows="5"
            ></v-textarea>
          </v-col>
        </v-row>
      </v-container>
    </v-form>
  </div>
</template>

<script>
export default {
  
}
</script>
import axios from 'axios'
const api = axios

const store = {
    actions: {
        getAnamnesis : async ({}) => {
            try {
                const response = await api.get('/anamnesis/secciones')
                if(response.status === 200) {
                    return response
                }
             
            } catch (error) {
                return error.response
            }
        },

        newClinicHistory : async({}, data: any) => {
            try {
                const response = await api.post('/HistoriaClinica/new', data)
                return response
            } catch (error) {
                return error
            }
        },

        CicloRehabilitacion : async ({ }, data: any) => {
            try {
                const response = await api.post('/CicloRehabilitacion', data)

                if(response.status === 200) {
                    return response
                }

            } catch (error) {
                return error
            }
        }

        
    }
}

export default store
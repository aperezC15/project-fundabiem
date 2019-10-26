import api from '../api'

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
            console.log(data)
            try {
                const response = await api.post('/historiaclinica', data)
                console.log(response)
            } catch (error) {
                console.log(error.response)
                return error
            }
        }
    }
}

export default store
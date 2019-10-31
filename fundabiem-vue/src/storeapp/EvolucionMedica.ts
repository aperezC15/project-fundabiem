import api from '../api'

const store = {
    actions: {
        newEvolutionMedical : async ({}, data: object) => {
            try {   
                const response = await api.post('/evolucion-medica', data)
                if(response.status === 200) {
                    return response
                }
            }catch(e) {
                return e.response
            }
        }
    }
}

export default store
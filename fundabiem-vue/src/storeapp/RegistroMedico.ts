import api from '../api'

const store = {
    actions: {
        newMedicalRegister: async({}, data : any) => {
            try {
                const response = await api.post('/newRegistroMedico', data)
                if(response.status === 200) {
                    return response
                }
            }catch(e) {
                return e.response
            }
        },
        getMedicalsRegistros : async ({}) => {
            try{
                const response = await api.get('/RegistroMedico')
                if( response.status === 200) {
                    return response
                }
            } catch(e) {
                return e.response
            }
        }
    }
}

export default store
import api from '../api'

const store = {
    actions: {
        newMedicalRegister: async({}, data : any) => {
            console.log(data)
            try {
                const response = await api.post('/RegistroMedico/new', data)
                if(response.status === 200) {
                    return response
                }
            }catch(e) {
                console.log(e.reponse)
                return e.response
            }
        },
        getMedicalsRegistros : async ({}) => {
            try{
                const response = await api.get('/RegistroMedico/getAll')
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
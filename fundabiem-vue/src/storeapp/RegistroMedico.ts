import api from '../api'

const store = {
    actions: {
        newMedicalRegister: async({}, data : any) => {
            console.log(data)
            try {
                const response = await api.post('/Fundabiem', data)
                console.log(response)
            }catch(e) {
                console.log(e.response)
            }
        }
    }
}

export default store
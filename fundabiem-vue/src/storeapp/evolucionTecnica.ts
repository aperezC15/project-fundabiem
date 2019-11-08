import axios from 'axios'
const api  = axios

const store = {
    actions: {

        newTechnicalEvolution :  async ({}, data: object) => {
            try {
                const response = await api.post('/EvolucionTecnica',data)
                console.log(response)
            } catch (error) {
                console.log(error.response)
            }
        }
    }
}

export default store
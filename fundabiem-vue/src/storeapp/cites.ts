import axios from 'axios'
const api = axios

const store = {
    actions: {
        newCites : async ({}, data: any) => {
            try {
                const response = await api.post('/Citas/new', data)

                if(response.status === 201) {
                    return response
                }

            } catch (e) {
                return e.response
            }
        },

        getAllCites: async ({}, data:any) => {

            try {
                const response = await api.get('Citas/searchByDates', {params: {...data}})
                if(response.status === 200) {
                    return response
                }
            } catch (error) {
                return error.response
            }
        }
    }
}

export default store
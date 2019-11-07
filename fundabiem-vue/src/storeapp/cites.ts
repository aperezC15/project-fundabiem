import api from '../api'

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
        }
    }
}

export default store
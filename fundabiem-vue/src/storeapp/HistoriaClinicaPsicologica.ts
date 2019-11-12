import axios from 'axios'
const api = axios

const store = {
   actions: {
    getAllHisotirasPsicologicas: async ({}, pagination:any) => {
        try{
            const response = await api.get('HistoriaClinicaPsicologica', {params: {pagina:pagination.pagination.pagina,rowsPerPage:pagination.pagination.rowsPerPage}})
            if(response.status === 200){
                return response
            }
        }catch(e){
            return e.response
        }
    }
   }
}

export default store
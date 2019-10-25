import axios from 'axios'

export default axios.create({
    baseURL: process.env.VUE_APP_URL_API,
    withCredentials: false,
    headers: {
        'Access-Control-Allow-Origin': '*',
        'Accept':'application/json',
        'Content-Type':'application/json',
    }
});
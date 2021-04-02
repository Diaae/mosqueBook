import axios from 'axios'
import { API,PORT } from './config';
const instance = axios.create({
  baseURL: API+':'+PORT,
  timeout: 60000
});
// var config = {
//   headers: {'Authorization': "Bearer " + localStorage.getItem("token")}
// };
export default {
  post: (url, object, callbackSuccess, callbackError) => {
    instance.post(url, object, config).then(callbackSuccess).catch(callbackError);
  },
  fetch: (url, callback, callbackError) => instance.get(url, config).then(callback).catch(callbackError === undefined ? (error) => {
    if(error.response!== undefined) {
      switch (error.response.status) {
        case 404:
          location.href = '/#/404';
          break;
      }
    }
  } : callbackError),
}

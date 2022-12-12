import { createApp } from 'vue'
import App from './App'
import router from "@/router/router";
import "bootstrap/dist/css/bootstrap.min.css"
import "bootstrap"
import 'bootstrap-icons/font/bootstrap-icons.css'

createApp(App)
    .use(router)
    .mount('#app')

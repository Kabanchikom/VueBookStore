import Catalog from "@/pages/Catalog";
import {createRouter, createWebHistory} from "vue-router";

const routes = [
    {
        path: '/',
        component: Catalog
    }
]

const router = createRouter({
    routes,
    history: createWebHistory(process.env.BASE_URL)
});

export default router;
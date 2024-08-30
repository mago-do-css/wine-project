// src/routes.js
import ListProdutos from '../pages/Products.vue'; 
import LandingPage from '../pages/LandingPage.vue';

export const routes = {
  '/': LandingPage,  
  '/listar-produtos': ListProdutos,  
};

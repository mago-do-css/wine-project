<template> 
    <section class="splide pb-6">
      <div class="splide__track">
        <ul class="splide__list">
          <li class="splide__slide" v-for="(product, index) in products" :key="index">
            <CardSlide 
              :productName="product.nome"
              :description="product.descricao"
              @edit="addToCart(product)"
            />
          </li> 
        </ul>
      </div>
    </section>
  </template>
<script>
import CardSlide from '../components/common/CardSlide.vue';
import Splide from '@splidejs/splide';
import '@splidejs/splide/css';

export default {
  name: 'SlideCardsProdutos',
  components: {
    CardSlide
  },
  data() {
    return {
      isEditing: false,
      editingProduct: null,
      products: [
        { nome: 'Vinho Tinto', descricao: 'Descrição do vinho tinto', estoque: 10, peso: 0.5, marca: 'marca' },
        { nome: 'Vinho Branco', descricao: 'Descrição do vinho branco', estoque: 5, peso: 0.6, marca: 'marca' },
        { nome: 'Vinho Branco', descricao: 'Descrição do vinho branco', estoque: 5, peso: 0.6, marca: 'marca' },
        { nome: 'Vinho Branco', descricao: 'Descrição do vinho branco', estoque: 5, peso: 0.6, marca: 'marca' },
        { nome: 'Vinho Branco', descricao: 'Descrição do vinho branco', estoque: 5, peso: 0.6, marca: 'marca' },
        { nome: 'Vinho Branco', descricao: 'Descrição do vinho branco', estoque: 5, peso: 0.6, marca: 'marca' },
        { nome: 'Vinho Branco', descricao: 'Descrição do vinho branco', estoque: 5, peso: 0.6, marca: 'marca' },
        { nome: 'Vinho Branco', descricao: 'Descrição do vinho branco', estoque: 5, peso: 0.6, marca: 'marca' },
      ],
    };
  },
  mounted() {
    this.initializeSplide();
  },
  methods: {
    initializeSplide() {
      new Splide('.splide', {
        type   : 'loop',
        perPage: 4,
        perMove: 1,
        breakpoints: {
          600: {
            perPage: 1,
          },
          1024: {
            perPage: 2,
          },
        },
      }).mount();
    },
    addToCart(product) { 
      // Lógica para adicionar o produto ao carrinho
    }
  }
}
</script>
  <style> 
  </style>
  
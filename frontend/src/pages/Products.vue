<template>
  <appLayout>
    <div v-if="isEditing">
      <h2 class="font-semibold text-[30px] mb-7">Editando produto...</h2>
      <form @submit.prevent="saveProduct" class="">
        <div class="flex">
          <div class="w-[30%] flex justify-between">
            <!-- imagem -->
            <div class="bg-white rounded-[26px] w-[400px] h-[200px] mr-4">
            </div>
          </div>
          <div class="w-[70%] flex">
            <div class="w-[50%] pr-3">
              <div class="flex flex-col w-full">
                <label for="productName">Nome do Produto:</label>
                <input class="bg-transparent rounded-full py-2 px-4 border border-solid border-1 border-[#1D1D1D]"
                  type="text" v-model="editingProduct.nome" id="productName" />
                <div class="mt-8 flex items-center">
                  <label for="stock">Quantidade Estoque</label>
                  <input
                    class="ml-4 w-[100px] text-center bg-transparent rounded-[10px] py-2 px-4 border border-solid border-1 border-[#1D1D1D]"
                    type="text" v-model="editingProduct.estoque" id="stock" />
                </div>
                <div class="mt-5 mb-6 flex items-center">
                  <label for="stock">Peso (kg)</label>
                  <input
                    class="ml-4 w-[100px] text-center bg-transparent rounded-[10px] py-2 px-4 border border-solid border-1 border-[#1D1D1D]"
                    type="text" v-model="editingProduct.peso" id="kg" />
                </div>
                <label for="productDescription">Descrição:</label>
                <textarea class="bg-transparent rounded-[10px] py-2 px-4 border border-solid border-1 border-[#1D1D1D]"
                  v-model="editingProduct.descricao" id="productDescription"></textarea>

              </div>
            </div>
            <div class="flex flex-col w-[50%]">
              <label for="productName">Marca do Produto:</label>
              <input class="mb-6 bg-transparent rounded-full py-2 px-4 border border-solid border-1 border-[#1D1D1D]"
                type="text" v-model="editingProduct.marca" id="productBrand" /> 
            </div>
          </div>
        </div>
        <div class="flex justify-start mt-5">
          <button type="submit"
            class="font-semibold underline mr-10 transition text-[#293D33] hover:text-[#44BB7F]">Salvar</button>
          <button type="button" @click="cancelEdit"
            class="font-semibold underline text-[#BE0707] hover:text-[#ff0b0b] transition">Cancelar</button>
        </div>
      </form>
    </div>
    <div v-else-if="isExcluding">
      <form @submit.prevent="excluirProduto">
      <input v-model="produtoId" placeholder="ID do Produto" />
      <button type="submit">Excluir Produto</button>
    </form>
    </div>
    <div v-else>
      <div class="">
        <Card v-for="(product, index) in products" :key="index" :productName="product.nome"
          :description="product.descricao" :stock="product.estoque" :kg="product.peso" @edit="editProduct(product)">
        </Card>
      </div>
    </div>
  </appLayout>
</template>

<script>
import appLayout from '../layouts/app.vue';
import Card from '../components/common/Card.vue';
import { ref } from 'vue';
import { useMutation } from '@apollo/client';  

 
export default {
  name: 'ListProdutos',
  components: {
    appLayout,
    Card
  },
  data() {
    return {
      isEditing: false,
      editingProduct: null,
      products: [
        { nome: 'Vinho Tinto', descricao: 'Descrição do vinho tinto', estoque: 10, peso: 0.5,marca: 'marca' },
        { nome: 'Vinho Branco', descricao: 'Descrição do vinho branco', estoque: 5, peso: 0.6, marca: 'marca'},
        { nome: 'Vinho Branco', descricao: 'Descrição do vinho branco', estoque: 5, peso: 0.6, marca: 'marca'},
        { nome: 'Vinho Branco', descricao: 'Descrição do vinho branco', estoque: 5, peso: 0.6, marca: 'marca'},
        { nome: 'Vinho Branco', descricao: 'Descrição do vinho branco', estoque: 5, peso: 0.6, marca: 'marca'},
        { nome: 'Vinho Branco', descricao: 'Descrição do vinho branco', estoque: 5, peso: 0.6, marca: 'marca'},
        { nome: 'Vinho Branco', descricao: 'Descrição do vinho branco', estoque: 5, peso: 0.6, marca: 'marca'},
        { nome: 'Vinho Branco', descricao: 'Descrição do vinho branco', estoque: 5, peso: 0.6, marca: 'marca'},
       
      ],
    };
  },
  methods: {
    editProduct(product) {
      console.log('Botão de edição clicado para:', product);
      this.editingProduct = { ...product };  
      this.isEditing = true;
    },
    async saveProduct() {
      console.log('Produto salvo:', this.editingProduct);
      const { data } = await this.$apollo.mutate({
          mutation: UPDATE_PRODUCT,
          variables: {
            produto: {
              id: this.editingProduct.id,
              nome: this.editingProduct.nome,
              descricao: this.editingProduct.descricao,
              estoque: this.editingProduct.estoque,
              marca: this.editingProduct.marca,
              peso: this.editingProduct.peso
            }
          }
        });

      // Atualize o produto na lista de produtos
      const index = this.products.findIndex(p => p.name === this.editingProduct.name);
      if (index !== -1) {
        this.products[index] = { ...this.editingProduct };
      }
      this.isEditing = false; 
    },
    cancelEdit() {
      this.isEditing = false;
    },
    async removeProduct(productId) {
      try {
        const { data } = await this.$apollo.mutate({
          mutation: REMOVE_PRODUCT,
          variables: {
            id: productId,
          },
        });

        if (data.removeProduct.success) {
          this.products = this.products.filter(p => p.id != productId);
          console.log('Produto removido com sucesso:', data.removeProduct.message);
        } else {
          console.error('Erro ao remover produto:', data.removeProduct.message);
        }

      } catch (error) {
        console.error('Erro ao executar mutação:', error);
      }
    },
  }
}
</script>

<style>
</style>

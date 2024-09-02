<template>
  <appLayout>
    <div v-if="isEditing">
      <h2 class="font-semibold text-[30px] mb-7">Editando produto...</h2>
      <form @submit.prevent="saveProduct">
        <div class="w-full mb-3">
        <label class="font-medium" for="id">Id</label>
        <input
          class="ml-4 w-[100px] text-center bg-transparent rounded-[10px] py-2 px-4 border border-solid border-1 border-[#1D1D1D]"
          type="text" v-model="editingProduct.id" id="id" />
                </div>
        <div class="flex">
          <div class="w-[30%] flex justify-between"> 
            <div class="bg-white rounded-[26px] w-[400px] mr-4 p-6">
              <img class="bg-white rounded-[26px] w-full mr-4" src="../assets/images/product.webp" alt="">
            </div>
          </div>
          <div class="w-[70%] flex">
            <div class="w-[50%] pr-3">
              <div class="flex flex-col w-full"> 
                <label class="font-medium mb-1" for="productName">Nome do Produto:</label>
                <input class="bg-transparent rounded-full py-2 px-4 border border-solid border-1 border-[#1D1D1D]"
                  type="text" v-model="editingProduct.nome" id="nome" />
                <div class="mt-8 flex items-center">
                  <label class="font-medium" for="stock">Quantidade Estoque</label>
                  <input
                    class="ml-4 w-[100px] text-center bg-transparent rounded-[10px] py-2 px-4 border border-solid border-1 border-[#1D1D1D]"
                    type="text" v-model="editingProduct.qtdeEstoque" id="qtdeEstoque" />
                </div>
                <div class="mt-5 mb-6 flex items-center">
                  <label class="font-medium" for="kg">Peso (kg)</label>
                  <input
                    class="ml-4 w-[100px] text-center bg-transparent rounded-[10px] py-2 px-4 border border-solid border-1 border-[#1D1D1D]"
                    type="text" v-model="editingProduct.peso" id="peso" />
                </div>
                <label class="font-medium mb-1" for="productDescription">Descrição:</label>
                <textarea class="bg-transparent rounded-[10px] py-2 px-4 border border-solid border-1 border-[#1D1D1D]"
                  v-model="editingProduct.descricao" id="descricao"></textarea>
              </div>
            </div>
            <div class="flex flex-col w-[50%]">
              <label class="font-medium mb-1" for="productBrand">Marca do Produto:</label>
              <input class="mb-6 bg-transparent rounded-full py-2 px-4 border border-solid border-1 border-[#1D1D1D]"
                type="text" v-model="editingProduct.marca" id="marca" /> 
              <label class="font-medium mb-1" for="productBrand">Preço:</label>
              <div class="flex w-[250px] 	text-center bg-transparent rounded-[10px] py-2 px-4 border border-solid border-1 border-[#1D1D1D]">
                <p class="mr-2">R$</p>
                <input class="w-full bg-transparent" type="text" v-model="editingProduct.preco" id="preco" /> 
              </div>
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
    <div v-if="isCreating">
      <h2 class="font-semibold text-[30px] mb-7">Criando produto...</h2>
      <form @submit.prevent="saveProduct"> 
        <div class="flex">
          <div class="w-[30%] flex justify-between"> 
            <div class="bg-white rounded-[26px] w-[400px] mr-4 p-6">
              <img class="bg-white rounded-[26px] w-full mr-4" src="../assets/images/product.webp" alt="">
            </div>
          </div>
          <div class="w-[70%] flex">
            <div class="w-[50%] pr-3">
              <div class="flex flex-col w-full"> 
                <label class="font-medium mb-1" for="productName">Nome do Produto:</label>
                <input class="bg-transparent rounded-full py-2 px-4 border border-solid border-1 border-[#1D1D1D]"
                  type="text" v-model="newProduct.nome" id="nome" />
                <div class="mt-8 flex items-center">
                  <label class="font-medium" for="stock">Quantidade Estoque</label>
                  <input
                    class="ml-4 w-[100px] text-center bg-transparent rounded-[10px] py-2 px-4 border border-solid border-1 border-[#1D1D1D]"
                    type="text" v-model="newProduct.qtdeEstoque" id="qtdeEstoque" />
                </div>
                <div class="mt-5 mb-6 flex items-center">
                  <label class="font-medium" for="kg">Peso (kg)</label>
                  <input
                    class="ml-4 w-[100px] text-center bg-transparent rounded-[10px] py-2 px-4 border border-solid border-1 border-[#1D1D1D]"
                    type="text" v-model="newProduct.peso" id="peso" />
                </div>
                <label class="font-medium mb-1" for="productDescription">Descrição:</label>
                <textarea class="bg-transparent rounded-[10px] py-2 px-4 border border-solid border-1 border-[#1D1D1D]"
                  v-model="newProduct.descricao" id="descricao"></textarea>
              </div>
            </div>
            <div class="flex flex-col w-[50%]">
              <label class="font-medium mb-1" for="productBrand">Marca do Produto:</label>
              <input class="mb-6 bg-transparent rounded-full py-2 px-4 border border-solid border-1 border-[#1D1D1D]"
                type="text" v-model="newProduct.marca" id="marca" /> 
              <label class="font-medium mb-1" for="productBrand">Preço:</label>
              <div class="flex w-[250px] 	text-center bg-transparent rounded-[10px] py-2 px-4 border border-solid border-1 border-[#1D1D1D]">
                <p class="mr-2">R$</p>
                <input class="w-full bg-transparent" type="text" v-model="newProduct.preco" id="preco" /> 
              </div>
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
      <form @submit.prevent="removeProduct(produtoId)">
        <input v-model="produtoId" placeholder="ID do Produto" />
        <button type="submit">Excluir Produto</button>
      </form>
    </div>
    <div v-else>
      <div>
        <Card v-for="(product, index) in products" :key="index" :nome="product.nome"
          :descricao="product.descricao" :estoque="product.qtdeEstoque" :peso="product.peso" @edit="editProduct(product)">
        </Card>
      </div>
    </div>
  </appLayout>
</template>

<script>
import { defineComponent, ref, computed, onMounted, watch } from 'vue';
import { useQuery, useMutation } from '@vue/apollo-composable';
import appLayout from '../layouts/app.vue';
import Card from '../components/common/Card.vue';
import { BUSCAR_TODOS_PRODUTOS } from '../graphql/queries/produtoQuery.js';
import { ATUALIZAR_PRODUTO } from '../graphql/mutations/AtualizarProdutoMutation.js';
import { CRIAR_PRODUTO } from '../graphql/mutations/AdicionarProdutoMutation.js';

export default defineComponent({
  name: 'ListProdutos',
  components: {
    appLayout,
    Card
  },
  setup() {
    const products = ref([]);
    const isEditing = ref(false);
    const editingProduct = ref(null);
    const produtoId = ref('');
    const isExcluding = ref(false);   
    const isCreating = ref(false);
    const newProduct = ref({ 
      nome: '',
      descricao: '',
      marca: '',
      peso: '',
      preco: '',
      qtdeEstoque: ''
    });
    const { result, loading, error } = useQuery(BUSCAR_TODOS_PRODUTOS);
    const { mutate: atualizarProduto }= useMutation(ATUALIZAR_PRODUTO); 
    const { mutate: criarProduto } = useMutation(CRIAR_PRODUTO); 

  
    const productsData = computed(() => {
      return result.value?.buscarTodosProdutos || [];
    });
 
    watch(productsData, (newValue) => {
      products.value = newValue;
    }, { immediate: true });


    const startCreate = async () => {  
      isCreating.value = true;
    };

    const cancelCreate = async () => {  
      isCreating.value = false;
    };
    
    onMounted(() => {
      if (loading.value) {
        console.log("Carregando produtos...");
      }
      if (error.value) {
        console.error("Erro ao buscar produtos:", error.value);
      }
    }); 

 
    const editProduct = (product) => {
      console.log('Botão de edição clicado para:'+ product);
      editingProduct.value = { ...product };
      isEditing.value = true;
    };
  
    const cancelEdit = () => {
      isEditing.value = false;
    };

    const removeProduct = async (productId) => {
      try {
       //mutation
      } catch (error) {
        console.error('Erro ao excluir produto:', error);
      }
    };

    const saveProduct = async (produto) => {
      produto.preventDefault();
      
       try { 
        console.log(produto.srcElement['marca'].value); 

        const produtoDTO = {
          id: parseInt(produto.srcElement['id'].value),
          descricao: produto.srcElement['descricao'].value,
          nome: produto.srcElement['nome'].value,
          marca: produto.srcElement['marca'].value,
          peso: parseFloat(produto.srcElement['peso'].value),
          preco: parseFloat(produto.srcElement['preco'].value),
          qtdeEstoque:  parseInt(produto.srcElement['qtdeEstoque'].value),
        };

        console.log('dados para enviar:', produtoDTO);

        const { data } = await atualizarProduto({ 
            input:{ 
              produtoDTO, 
            } 
        });  

        console.log("retorno:");
        console.log(data);
 
        isEditing.value = false;
      } catch (error) {
          console.error('Erro ao salvar produto:', error);
      }
    }; 

    const createProduct = async () => {
      try {
        const { data } = await criarProduto({
          input: {
            nome: newProduct.value.nome,
            descricao: newProduct.value.descricao,
            marca: newProduct.value.marca,
            peso: parseFloat(newProduct.value.peso),
            preco: parseFloat(newProduct.value.preco),
            qtdeEstoque: parseInt(newProduct.value.qtdeEstoque)
          }
        });

        if (data && data.criarProduto) {
          products.value.push(data.criarProduto);
        }

        isCreating.value = false;
      } catch (error) {
        console.error('Erro ao criar produto:', error);
      }
    };

    return {
      products,
      isEditing,
      editingProduct,
      produtoId,
      isExcluding,
      editProduct,
      saveProduct,
      cancelEdit,
      removeProduct,
      loading,
      error
    };
  }
});
</script>

<style>
</style>

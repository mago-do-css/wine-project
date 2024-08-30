import { createStore } from 'vuex';
import { gql } from 'graphql-tag';
import apolloClient from '../apolloClient'; // ajuste o caminho conforme necessário

const UPDATE_PRODUCT = gql`
  mutation AtualizarProduto($produto: ProdutoInput!) {
    atualizarProduto(produto: $produto) {
      id
      nome
      descricao
      estoque
      marca
      peso
    }
  }
`;

const DELETE_PRODUCT = gql`
  mutation ExcluirProduto($id: ID!) {
    excluirProduto(id: $id)
  }
`;

const store = createStore({
  state() {
    return {
      products: [
        {
          id: 1,
          nome: 'Vinho Tinto Premium',
          descricao: 'Um vinho tinto encorpado com notas de frutas vermelhas.',
          estoque: 30,
          marca: 'Vinhos Elegantes',
          peso: 0.75
        },
        {
          id: 2,
          nome: 'Vinho Branco Suave',
          descricao: 'Um vinho branco leve e refrescante com notas cítricas.',
          estoque: 20,
          marca: 'Vinhos Frescos',
          peso: 0.75
        },
        {
          id:3,
          nome: 'Champanhe Brut',
          descricao: 'Uma champanhe espumante com bolhas finas e sabor seco.',
          estoque: 15,
          marca: 'Champagnes Delicados',
          peso: 0.75
        }
      ],
      successMessage: '',
      errorMessage: ''
    };
  },
  mutations: {
    setSuccessMessage(state, message) {
      state.successMessage = message;
    },
    setErrorMessage(state, message) {
      state.errorMessage = message;
    },
    setProducts(state, products) {
      state.products = products;
    }
  },
  actions: {
    async atualizarProduto({ commit }, produto) {
      try {
        const { data } = await apolloClient.mutate({
          mutation: UPDATE_PRODUCT,
          variables: {
            produto
          }
        });
        commit('setSuccessMessage', `Produto ${data.atualizarProduto.nome} atualizado com sucesso!`);
        commit('setErrorMessage', '');
      } catch (error) {
        commit('setSuccessMessage', '');
        commit('setErrorMessage', `Erro ao atualizar produto: ${error.message}`);
      }
    },
    async excluirProduto({ commit }, produtoId) {
      try {
        await apolloClient.mutate({
          mutation: DELETE_PRODUCT,
          variables: {
            id: produtoId
          }
        });
        commit('setSuccessMessage', 'Produto excluído com sucesso!');
        commit('setErrorMessage', '');
      } catch (error) {
        commit('setSuccessMessage', '');
        commit('setErrorMessage', `Erro ao excluir produto: ${error.message}`);
      }
    },
    async fetchProducts({ commit }) {
      // Adicione sua lógica para buscar produtos aqui
       commit('setProducts', fetchedProducts);
    }
  }
});

export default store;

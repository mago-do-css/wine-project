import { gql } from '@apollo/client';

export const BUSCAR_TODOS_PRODUTOS = gql`
  query {
    buscarTodosProdutos {
      id
      nome
      descricao
      marca
      peso
      preco
      qtdeEstoque
    }
  }
`;

export const BUSCAR_POR_ID = gql`
query BuscarProdutoPorId($id: ID!) {
    buscarProdutoPorId {
      id 
    }
}`;

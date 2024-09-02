
import { gql } from '@apollo/client';

export const CRIAR_PRODUTO = gql`
  mutation adicionarProduto($input: AtualizarProdutoInput!){
    adicionarProduto(input: $input) {
      produtoDTO {
        id
        descricao
        nome
        peso
        preco
        marca
        qtdeEstoque
      }
    } 
  }
`;
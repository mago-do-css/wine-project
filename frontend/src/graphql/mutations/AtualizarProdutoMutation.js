
import { gql } from '@apollo/client';

export const ATUALIZAR_PRODUTO = gql`
  mutation atualizarProduto($input: AtualizarProdutoInput!){
    atualizarProduto(input: $input) {
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
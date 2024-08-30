import { gql } from '@apollo/client';

export const EXCLUIR_PRODUTO = gql`
  mutation ExcluirProduto($id: ID!) {
    excluirProduto(id: $id) {
      success
      message
    }
  }
`;

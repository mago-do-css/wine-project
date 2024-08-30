import { gql } from '@apollo/client';

export const ATUALIZAR_PRODUTO = gql`
  mutation AtualizarProduto(
    $id: ID!
    $nome: String!
    $descricao: String!
    $estoque: Int!
    $peso: Float
    $marca: String
  ) {
    atualizarProduto(
      produto: {
        id: $id
        nome: $nome
        descricao: $descricao
        estoque: $estoque
        peso: $peso
        marca: $marca
      }
    ) {
      id
      nome
      descricao
      estoque
      peso
      marca
    }
  }
`;

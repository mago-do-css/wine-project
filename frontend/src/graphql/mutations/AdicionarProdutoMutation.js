import { gql } from '@apollo/client';

export const ADICIONAR_PRODUTO = gql`
  mutation AdicionarProduto(
    $id: ID!
    $nome: String!
    $descricao: String!
    $estoque: Int!
    $peso: Float
    $marca: String
  ) {
    adicionarProduto(
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

import { ApolloClient, InMemoryCache } from '@apollo/client/core';
import { provideApolloClient } from '@vue/apollo-composable';

const apolloClient = new ApolloClient({
  uri: 'http://127.0.0.1:5057/graphql',
  cache: new InMemoryCache(),
});

// Exporta o cliente Apollo para uso em outros arquivos
export default apolloClient;

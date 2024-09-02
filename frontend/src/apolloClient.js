import { ApolloClient, InMemoryCache } from '@apollo/client/core';
import { provideApolloClient } from '@vue/apollo-composable';

const apolloClient = new ApolloClient({
  uri: 'https://localhost:7173',
  cache: new InMemoryCache(),
});

provideApolloClient(apolloClient);  

export default apolloClient;

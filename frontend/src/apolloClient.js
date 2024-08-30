import { ApolloClient, InMemoryCache } from '@apollo/client';

const apolloClient = new ApolloClient({
  uri: 'http://127.0.0.1:5057/graphql', // Substitua pela URI do seu endpoint GraphQL
  cache: new InMemoryCache()
});

export default apolloClient;

import { createApp, h, provide } from 'vue';
import './css/app.css';
import App from './App.vue';
import { ApolloClient, InMemoryCache } from '@apollo/client';
import { DefaultApolloClient, provideApolloClient } from '@vue/apollo-composable'; 
import PrimeVue from 'primevue/config';
import { useRouter } from 'vue-router';
import store from './stores/produtos';
 
const apolloClient = new ApolloClient({
    uri: 'http://127.0.0.1:5057/graphql',
    cache: new InMemoryCache(),
  });

const app = createApp({
    setup(){
        provide(DefaultApolloClient, apolloClient);
    },
    render: () => h(App),
});

app.use(PrimeVue);
app.use(useRouter);
app.use(store);

createApp(App).mount('#app') 
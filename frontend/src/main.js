import { createApp, h, provide } from 'vue';
import './css/app.css';
import App from './App.vue';
import { ApolloClient } from '@apollo/client';
import { DefaultApolloClient } from '@vue/apollo-composable';
import PrimeVue from 'primevue/config';
import { useRouter } from 'vue-router';

const app = createApp({
    setup(){
        provide(DefaultApolloClient, apolloClient);
    },
    render: () => h(App),
});

app.use(PrimeVue);
app.use(useRouter);

createApp(App).mount('#app')

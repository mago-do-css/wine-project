<template> 
    <component :is="currentPage"></component> 
</template>

<style scoped>
</style>

<script>
import { ref } from 'vue';
import { routes } from '../src/routes/routes'; 

export default {
  name: 'App',
  setup() {
    const currentPage = ref(routes[window.location.pathname] || routes['/']);

    function navigate(path) {
      window.history.pushState({}, '', path);
      currentPage.value = routes[path] || routes['/'];
    }
 
    window.addEventListener('popstate', () => {
      currentPage.value = routes[window.location.pathname] || routes['/'];
    });

    return {
      currentPage,
      navigate
    };
  }
};
</script>
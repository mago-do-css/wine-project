<template> 
      <header class="flex justify-between w-[1200px] mx-auto items-center mb-12 py-4"> 
       <Logo></Logo>
        <div class="bg-white rounded-full w-[40px] h-[40px] text-center flex items-center justify-center">
          <Avatar icon="pi pi-user" size="xlarge" shape="circle" />
        </div>
      </header>
      <div class="flex">
         <Navigation></Navigation>
      </div>
      <main class="bg-[#D9D9D9] w-[1200px] mx-auto rounded-[26px] p-10">
        <slot></slot>
      </main> 
     
    <footer class="text-center flex flex-col justify-center items-center py-5">
        <img src="../assets/images/logo-black.png" alt="">
        <p class="text-[14px] mt-5">© 2024 Adega Online. Todos os direitos reservados.</p>
    </footer>
  </template> 
  <script>
  import Avatar from 'primevue/avatar';
  import 'primeicons/primeicons.css';
  import Navigation from '../components/Navigation.vue'; 
  import Logo from '../components/common/Logo.vue';

  export default {
    name: 'appLayout', 
    components: {
      Avatar,
      Navigation,
      Logo
    }
  }
  </script>
  
  <style>
  html{
    background-color: #969696;
   }
  </style>
  
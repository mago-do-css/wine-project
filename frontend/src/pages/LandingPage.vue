<template>
  <lpLayout>
    <div class="mx-auto w-[1200px] pt-[100px] pb-[50px] flex items-center justify-between">
      <h1 class="text-[35px] font-medium">Safra lorem ispum </h1>
      <ButtonColor 
      text="Ver Mais" 
      textColor="#1D1D1D"
      backgroundColor="#f5f9ff"  
      borderColor="#1D1D1D"
      ></ButtonColor>
    </div> 
    <section class="mx-auto w-[1200px]">
      <SlideCardsProdutos></SlideCardsProdutos>
    </section>
    <section class="mx-auto w-[1200px] py-[100px] flex items-center">
      <div  class="w-[50%]">
        <h2 class="font-medium text-[40px] leading-none mb-4">Qualidade comprovada por especialistas!</h2>
        <p class="text-[18px]">lorem ispum dolor sit amet lorem ispum dolor sit amet lorem ispum dolor sit amet lorem ispum dolor sit amet</p>
      </div>
      <div class="w-[50%]">
        <img class="w-[80%] float-right rounded-2xl" src="../assets/images/image-company-wine.jpg" alt="">
      </div>
    </section>
  </lpLayout>
</template> 
<script>  
 import lpLayout from '../layouts/lp.vue';
 import ButtonColor from '../components/common/ButtonColor.vue';
 import SlideCardsProdutos from '../components/SlideCardsProdutos.vue';

export default {
  name: 'LandingPage',
  components: { 
    lpLayout, 
    ButtonColor,
    SlideCardsProdutos
  },

  data() {
    return {
    };
  },
  methods: { 
  }, 
}
</script>

<style>
</style>

<template> 
    <div class="flex mb-4 mx-3 flex-col justify-center items-start">
        <div class="rounded-[25px] bg-white w-full flex items-center justify-center p-6">
            <img class="w-auto h-[200px]" src="../../assets/images/product.webp" alt="">
        </div>
        <div class="text-left pt-6">
            <h3 class="text-lg font-bold">{{ productName }}</h3>
            <p class="mb-6">{{ description }}</p>
            <a href="" class="font-medium underline hover:text-[#293D33]">Adicionar ao carrinho</a>
        </div>
    </div>
</template>

<script> 

export default {
  name: 'CardSlide', 
  props:{
    productName:{
        type: String,
        default: 'Nome do produto'
    },
    description:{
        type: String,
        default: 'Lorem ispum dolor sit amet'
    }, 
  }, 
}
</script>

<style>
 
</style>

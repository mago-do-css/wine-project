<template> 
    <div class="flex mb-4">
        <div class="rounded-[11px] bg-white h-[100px] w-[100px] mr-5"> 
            <img class="p-2 rounded-full" src="../../assets/images/product.webp" alt="" />
        </div>
        <div class="flex flex-col justify-around">
            <div class="flex items-baseline">
                <div>
                    <h2 class="text-[20px] font-semibold">{{ nome }}</h2>
                    <p>{{ descricao }}</p>
                </div>
                <h3 class="ml-4 font-medium">{{ estoque }}x</h3>
            </div>
            <div>
                <button @click="handleclick" 
                        class="font-semibold underline mr-10 transition text-[#293D33] hover:text-[#44BB7F]">Editar</button>
                <button class="font-semibold underline text-[#BE0707] hover:text-[#ff0b0b] transition">Remover</button>
            </div>
        </div> 
    </div>
</template>

<script> 

export default {
  name: 'Card', 
  props:{
    nome:{
        type: String,
        default: 'Nome do produto'
    },
    description:{
        type: String,
        default: 'Lorem ispum dolor sit amet'
    },
    estoque:{
        type: Number,
        default:10
    },
    peso:{
        type: Number,
        default:0.5
    },
    marca:{
        type: String,
        default:'Marca'
    }
  },
  methods:{
    handleclick(){
        this.$emit('edit');
    }
  }
}
</script>

<style>
 
</style>

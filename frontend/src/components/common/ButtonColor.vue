<template> 
  <button :style="{ backgroundColor: color}" class="py-2 px-5 font-medium text-[16px] rounded-full transition hover:bg-[#293D33] ">
    {{ text }}
  </button>
</template>

<script> 

export default {
  name: 'ButtonColor', 
  props:{
    text:{
        type: String, 
    },  
    color: {
      type: String,
    },  
  },
}
</script>

<style>
 
</style>

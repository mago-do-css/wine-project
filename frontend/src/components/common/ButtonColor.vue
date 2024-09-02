<template> 
  <button 
    :style="buttonStyle"
    @mouseenter="isHovered = true"
    @mouseleave="isHovered = false"
    class="py-2 px-5 font-medium text-[16px] rounded-full transition"
  >
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
    backgroundColor: {
      type: String,
    },  
    textColor: {
      type: String,
    },
    borderColor: {
      type: String,
    }
  },
  data(){
    return{
      isHovered:false,
    };
  },
  computed: {
    buttonStyle() {
      return {
        backgroundColor: this.isHovered ? this.textColor : this.backgroundColor,
        color: this.isHovered ? this.backgroundColor : this.textColor,
        border: (this.borderColor != 'noColor') ? `1px solid ${this.borderColor}` : `1px solid ${this.textColor}`,
      };
    },
  },
}
</script>

<style>
 
</style>

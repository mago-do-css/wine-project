<template>
    <section class="background-image">
        <div class="relative w-full">
            <header class="absolute  w-full items-center mb-12 py-9">
                <div class="w-[1200px] mx-auto flex justify-between ">
                    <logo></logo>
                    <div>
                        <a href="" class="mr-5">
                            <ButtonColor
                         backgroundColor="white" 
                         textColor="#1d1d1d" 
                         text="Entrar"
                         borderColor="white"
                        />
                        </a>
                        <a href="">
                            <ButtonColor
                             backgroundColor=""
                             hover="white" 
                             textColor="white" 
                             text="Login"
                             borderColor="white"
                            />
                        </a>  
                    </div>
                </div>
            </header>
            <div class="h-full flex flex-col justify-center items-start w-[1200px] mx-auto align">
                <h1 class="text-white text-[38px] xl:text-[45px] leading-none 2xl:text-6xl font-light">
                    Tenha <span class="text-[#03bd60] font-semibold" style="text-shadow:1px 1px 2px black;
                    ">vinhos exclusivos</span> para refinar seu paladar<br class="2xl:hidden"> sem precisar sair de casa!
                                    </h1>
                <p  style="text-shadow:1px 1px 2px black;" class="text-white mt-8 text-[18px] w-[80%] font-normal"> Com nossa adega online, você desfruta da conveniência de receber vinhos premiados diretamente na sua porta, sem comprometer a qualidade.
                    Descubra rótulos sofisticados e novidades emocionantes que prometem enriquecer seus momentos de celebração ou simplesmente tornar o dia a dia mais especial.</p>
            </div>
            <div class="absolute w-full z-50 justify-center flex mt-[-150px] flex-col items-center">
               <IconMouse></IconMouse>
                <a href="" class="text-white mt-6 hover:underline">Veja mais</a>
            </div>
        </div>
    </section>   
    <main class="bg-[#F5F9FF]">
        <slot></slot>
    </main>

    <footer class="text-center bg-[#F5F9FF] flex flex-col justify-center items-center py-5">
        <img src="../assets/images/logo-black.png" alt="">
        <p class="text-[14px] mt-5">© 2024 Adega Online. Todos os direitos reservados.</p>
    </footer>
</template>

<script>
import logo from '../components/common/Logo.vue';
import ButtonColor from '../components/common/ButtonColor.vue';
import { useTransition } from 'react';
import IconMouse from '../components/common/IconMouse.vue'; 
export default {
    name: 'lpLayout',
    components: {
        logo,
        ButtonColor,
        IconMouse
    }
}
</script>

<style>
.background-image {
    background-image: url('../assets/images/background.png');
    background-size: cover;
    background-repeat: no-repeat;
    height: 80vh;
}

.background-image>div:nth-child(1) {
    background-color: rgba(0, 0, 0, 0.486);
    width: 100%;
    height: 100%;
    backdrop-filter: blur(5px);
}
</style>

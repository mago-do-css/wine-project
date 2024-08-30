<template>
    <section class="background-image">
        <div class="relative w-full">
            <header class="absolute  w-full items-center mb-12 py-9">
                <div class="w-[1200px] mx-auto flex justify-between ">
                    <logo class=""></logo>
                    <div>
                        <ButtonColor color="white" text="Entrar" hover="#293D33" />
                        <button
                            class="rounded-full  text-white px-4 py-2 rounded-full ml-6 border-1 border hover:bg-white transition hover:text-black">Login</button>
                    </div>
                </div>
            </header>
            <div class="h-full flex flex-col justify-center items-start w-[1200px] mx-auto align">
                <h1 class="text-white text-6xl">Lorem ipsum dolor sit amet</h1>
                <p class="text-white mt-4">lorem ispum dolor sit amet lorem ispum dolor sit amet Vinhos Excepcionais Direto da Adega ao Seu Copo</p>
            </div>
            <div class="absolute w-full z-50 justify-center flex mt-[-150px] flex-col items-center">
               <IconMouse></IconMouse>
                <p class="text-white">scrow down</p>
            </div>
        </div>
    </section>
    <div class="flex">

    </div>
    <main class="bg-[#D9D9D9] w-[1200px] mx-auto rounded-[26px] p-10">
        <slot></slot>
    </main>

    <footer>
        <p>Meu Rodapé</p>
        <!-- Adicione aqui seu conteúdo de rodapé -->
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

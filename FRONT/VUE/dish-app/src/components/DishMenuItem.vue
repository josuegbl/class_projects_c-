<script>
export default
    {
        name: "DishMenuItem"
        , props: {
            dish: Object
        }
        // , data() 
        // {
        //     return  {
        //         dish: {
        //             name: "plato"
        //             , price: 20
        //         }
             
        //     }
        // } , methods:
        //     {
        //         showMessage, onSale
            // }
        
    };

    function showMessage(dish, event) 
    {
        console.log("ShowMessage");
        console.log(event);
        console.log(event.target);
        console.log(event.target.innerText)

        document.getElementById("messageDiv").textContent 
        = event.target.innerText
        + " es barato. compra el plato " + dish.name;
    };
    function onSale()
    {
        console.log("OnSale")

        this.dish.price = 5;

    }

</script>

<template>
    <img 
        src="../assets/chuleton-de-ternera.jpg" 
        v-bind:alt="dish.name"
        width="250em"></img>
    <h2>{{ dish.name }}</h2>
    <h3>{{ dish.price }}</h3>
    <h4 v-if="dish.price <=30">¡Ocasion!</h4>
    <h4 v-else>Muy rico</h4>
    <!-- <h3 v-on:mouseleave="showMessage(dish, $event)">{{ dish.price }}</h3> -->
    <!-- <div id="messageDiv"></div>
    <button v-on:click="onSale()">Poner en Oferta</button> -->
</template>

<style></style>

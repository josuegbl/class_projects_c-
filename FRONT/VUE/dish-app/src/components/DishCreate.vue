<script>
export default
    {
        name: "DishCreate"
      , data() 
        {
            return  {mutDish: Object }
        }
      , methods: 
        {
            createDish
        }
      , emits: ["dishCreated"]
    }

    function createDish(event)
    {
        console.log("create Dish in CreateDsh")
        let nameDish = document.getElementById("dishName").value;
        console.log(nameDish)
        let priceDish = document.getElementById("dishPrice").value;
        console.log(priceDish)

        this.mutDish =
        {
            name: nameDish,
            price: priceDish
        }

        this.emits(event, {dish: this.mutDish})

    }
</script>

<template>
    <div>
        <span>Nuevo plato</span>
        <br>
        <label for="dishName">Nombre</label>
        <input type="text" id="dishName">
        <br>
        <label for="dishPrice">Precio</label>
        <input type="number" id="dishPrice">
        <br>
        <button v-on:click="createDish($event)"> Crear Plato</button>

    </div>

</template>

<style></style>

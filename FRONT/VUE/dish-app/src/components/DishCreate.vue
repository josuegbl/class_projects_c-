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
            create
        }
        , emits: ["storeNewDish"]
    }

    function create()
    {
        console.log("create Dish in DIshCreate.vue")
        let nameDish = document.getElementById("dishName").value;
        console.log(nameDish)
        let priceDish = document.getElementById("dishPrice").value;
        console.log(priceDish)

        this.mutDish =
        {
            name: nameDish,
            price: priceDish
        }

        this.$emit("storeNewDish", {dish: this.mutDish})

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
        <button v-on:click="create"> Crear Plato</button>

    </div>

</template>

<style></style>

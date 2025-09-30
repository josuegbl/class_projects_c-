<script>
export default {
      name: "DishDM"
    , props:  {
        dishes: {  
            type: Array
            , default: 
                [
                    {
                        name: "plato1"
                        , price: 20
                    }
                    , {
                        name: "plato2"
                        , price: 30
                    }
                    , {
                        name: "plato3"
                        , price: 40
                    }
                ]
        }

    }
    , emits: [
        "dishesUpdated"
    ]
    , created() {
        console.log("Created en DishDM");
        console.log(this.dishes);

        this.$emit("dishesUpdated", {dishes: this.dishes})
    }

}
</script>

<template>
</template>

<style></style>

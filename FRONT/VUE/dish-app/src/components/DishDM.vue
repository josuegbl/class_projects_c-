<script>
export default
    {
        name: "DishDM"
        , props:
        {
            dishes:
            {
                type: Array
                , default:
                    [
                        {
                            id: "1"
                            , name: "plato1"
                            , price: 20
                        }
                        , {
                            id: "2"
                            , name: "plato2"
                            , price: 30
                        }
                        , {
                            id: "3"
                            , name: "plato3"
                            , price: 40
                        }
                    ]
            }
            , dishId: String
        }
   
        , emits: [
            "dishesUpdated"
        ]
        , created() {
            console.log("Created en DishDM");
            console.log(this.dishes);

            this.$emit("dishesUpdated", { dishes: this.dishes })
        }

    }
</script>

<template>
</template>

<style></style>

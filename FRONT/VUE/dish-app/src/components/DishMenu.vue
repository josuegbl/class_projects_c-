<script>
import DishCreate from './DishCreate.vue';
import DishDM from './DishDM.vue';
import DishMenuItem from './DishMenuItem.vue';

export default 
{
    name: "DishMenu",
    components: 
    {
        DishMenuItem, DishDM, DishCreate
    }
    , data() 
        {
            return {
                    mutableDishes: this.dishes
                  , mutDish: Object
                   }
        }
    , props:  {
        dishes: 
        {  
            type: Array
            , default: []
        }

    }
    , methods: 
    {
        dishesUpdated, createDish
    }
}

function createDish(event)
{
    console.log("create Dish en MENU")
}
// {
//     console.log("createDish");
//     // console.log(this.mutableDishes)
//     let dishName = document.getElementById("dishName").value;
//     console.log("dishName es " + dishName)
//     let dishPrice = document.getElementById("dishPrice").value;
//     console.log("dishPrice es " + dishPrice)

//     // this.mutableDishes.push(
//     // {
//     //     id: this.mutableDishes.length + 1
//     //     , name: dishName
//     //     , price: dishPrice
//     // });
 

//     // SPREAD SYNTAX
//     this.mutableDishes = 
//     [ ...this.mutableDishes
//     , 
//     {
//         id: this.mutableDishes.length + 1
//         , name: dishName
//         , price: dishPrice
//     }
//     ]
// }

function dishesUpdated(event)
{
    console.log("dishesUpdated en DishMenu");
    console.log(event);
    this.mutableDishes = event.dishes;

}

</script>

<template>
    <div>
        <div>
            <h3>
                Menu
            </h3>
            <DishMenuItem 
            v-for="(dish, index) in mutableDishes"
            v-bind:dish="dish"
            v-bind:key="index">
            </DishMenuItem>
        </div>

        <DishCreate v-on:dish-created="createDish($event)"></DishCreate>

    </div>
    <DishDM v-on:dishes-updated="dishesUpdated($event)"></DishDM> 

</template>

<style>
</style>

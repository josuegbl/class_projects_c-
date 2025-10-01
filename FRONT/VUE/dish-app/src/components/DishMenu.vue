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
                    , dishId: String
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
        dishesUpdated, createDish, removeDish
    }
}

function createDish(event)
{
    console.log("create Dish en MENU")
    let mutDish = event.dish;

    // console.log("nombre: " + mutDish.name)
    // console.log("nombre: " + mutDish.price)

    this.mutableDishes.push(
    {

        id: String(this.mutableDishes.length + 1)
        , name: mutDish.name
        , price: mutDish.price
    });
}
function removeDish(event)
{
    console.log("remove en el Menu");
    console.log("Borrar el id " + event.dishId);
    this.dishId = event.dishId;

    let newMuteableDIshes = [];
    this.mutableDishes.forEach((dish) => {
        console.log("id a borrar: " + this.dishId)
        console.log("id de dish borrar: " + dish.id)
        console.log(dish.id != this.dishId)
 
        if(dish.id != this.dishId)
        {
            newMuteableDIshes.push(dish)
        }
    });
    this.mutableDishes = newMuteableDIshes;
    
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
            <DishMenuItem v-on:remove-dish="removeDish($event)" 
            v-for="(dish, index) in mutableDishes"
            v-bind:dish="dish"
            v-bind:key="index">
            </DishMenuItem>
        </div>

        <DishCreate v-on:store-new-dish="createDish($event)"></DishCreate>

    </div>
    <DishDM 
    v-on:dishes-updated="dishesUpdated($event)"
    ></DishDM> 

</template>

<style>
</style>

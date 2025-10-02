import { useState } from "react";
import DishCreate from "../DishCreate/DishCreate";
import DishMenuItem from "../DishMenuItem/DishMenuItem";
import DishDM from "../DIshDM/DishDM";

const DishMenu = () => {
    function dishesChanger(dishes)
    {
        setDishes(dishes);
        console.log("dishesChanger")
    }

    const [dishes, setDishes] = useState([]);

    const listOfDishes = dishes.map(
        dish => <DishMenuItem key={dish.id} dish={dish}
        dishesChanger={dishesChanger} dishes={dishes}></DishMenuItem>
    )

    return(
        <div>
            <div>
                <h3>Menu</h3>
                {listOfDishes}
            </div>
                
        <div>
            <DishCreate dishesChanger={dishesChanger} dishes={dishes}></DishCreate>
        </div>
            <DishDM dishesChanger={dishesChanger}></DishDM>
            
        </div>
    )
};

export default DishMenu;
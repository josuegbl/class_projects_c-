import { useState } from "react";

const DishMenuItem = (props) => {


    // function showMessage(event) 
    // {
    //     console.log("showMessage");
    //     console.log(event);
    //     console.log(event.target);
    //     console.log(event.target.innerText);
    
    //     document.getElementById("messageDiv").textContent 
    //     = event.target.innerText
    //     + " es barato ¡compra el plato! " + dish.name;
    // }
    
    // function onSale() 
    // {
    //     console.log("onSale")
    //     setDish(
    //         {
    //             ...dish
    //             ,  price: 5
    //         }
    //     )
    // }

    function removeDish()
    {
        console.log("removeDish id: " + props.dish.id);
        console.log(props.dishesChanger);

        let newDishes = [];

        props.dishes.forEach(dish => {
            if(dish.id != props.dish.id)
            { 
               newDishes = [...newDishes, dish] 
            }
        });

        props.dishesChanger(newDishes);

        }


    return(
        <>
            <img 
                src="chuleton-de-ternera.jpg"
                alt={props.dish.name}
                width="20%"
                />
            <h2>{props.dish.name}</h2>
            <h3>{props.dish.price}</h3>
            <button onClick={removeDish}>Borrar</button>
            <h4>{props.dish.price <= 30 ? "Ocasion": "Muy rico!"}</h4>
            {/* <h3 onMouseLeave={showMessage}>{props.dish.price}</h3>
            <div id="messageDiv"></div>
            <button onClick={onSale}>Poner en oferta</button> */}
        </>
    ) 
};

export default DishMenuItem;
const DishCreate = (props) => {
    return(
        <div>
            <span>Nuevo plato</span>
            <br/>
            <label htmlFor="dishName">Nombre</label>
            <input type="text" id="dishName" />
            <br/>
            <label htmlFor="dishPrice">Precio</label>
            <input type="number" id="dishPrice"/>
            <br/>
            <button onClick={createDish}> Crear</button>
        </div>
    )

    function createDish()
    {
        console.log("createDish");
        let dishName = document.getElementById("dishName").value;
        console.log(dishName);
        
        let dishPrice = document.getElementById("dishPrice").value;
        console.log(dishPrice);

        console.log(props.dishes)

        let dish = {
        id: (props.dishes.length + 1).toString()
        , name: dishName
        , price: dishPrice
        }


        props.dishesChanger([...props.dishes, dish]);
    }


};

export default DishCreate;
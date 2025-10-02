import { useEffect } from "react";

const DishDM = (props) => {

    useEffect(
        () => {
            console.log("Effect en DM");

            props.dishesChanger(
                [
                    {
                        id: "1"
                        , name: "plato1"
                        , price: 20
                    }, {
                        id: "2"
                        , name: "plato2"
                        , price: 30
                    }, {
                        id: "3"
                        , name: "plato3"
                        , price: 40
                    }
                ]
        
            );

        }, []
    )


    return(
        <h2></h2>
    ) 
};

export default DishDM;
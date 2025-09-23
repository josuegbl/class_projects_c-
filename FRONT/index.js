// console.log("hola mundo");
// console.log("HANDLER");
// console.warn("amarillo");
// console.error("rojo");

// variables
// var nombre = "Abraham";

// let apellido1 = "Jimenez";
// const PI = 3.14;

//funciones
// function nombreFuncion(param1, param2) {
//     return 2;    
// }

// const suma = (param1, param2) => {
//     return param1+param2;
// }

//handler

//regex = Expresiones regulares 
var reg = /\D/g
var reg = /\d/g
var reg = /[0-9]/g


const formSubmitHandler = (event) => {
    event.preventDefault();

    let fullAddress = document.querySelector('input[name="formRoadType"]:checked').value + " " +
    document.getElementById("formAddress").value + " " +
    document.getElementById("formAddressFloor").value + " " +
    document.getElementById("formAddressDoor").value;

    let person = {
        name: document.getElementById("formName").value,
        surname1: document.getElementById("formSurname1").value,
        surname2: document.getElementById("formSurname2").value,
        fullAddress: fullAddress,
    }
    console.log(person);

    localStorage.setItem("person",JSON.stringify(person));

    console.log(JSON.parse(localStorage.getItem("person")));
    
}

const onDOMLoad = () => {
    document.getElementById("formSubmit").addEventListener("click", formSubmitHandler);
    //document.querySelector("fieldset>div.row>div.col").addEventListener("click", funcion2);
    document.querySelectorAll(".numberOnly").forEach(x => x.addEventListener("input",(event) => {
        event.target.value = event.target.value.replace(/\D/g, "");
    }))

    

    const toastTrigger = document.getElementById('formLoadData');
    const toastLiveExample = document.getElementById('liveToast');

    if (toastTrigger) {
    const toastBootstrap = bootstrap.Toast.getOrCreateInstance(toastLiveExample)
    toastTrigger.addEventListener('click', (event) => {
        event.preventDefault();
        let personLoaded = JSON.parse(localStorage.getItem("person"));

        document.querySelector("#liveToast>div.toast-body").innerText =
        personLoaded.name + " " + personLoaded.surname1 + " " + personLoaded.surname2;
        toastBootstrap.show();
    })
    }


}


document.addEventListener("DOMContentLoaded", onDOMLoad);



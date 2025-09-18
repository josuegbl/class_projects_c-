function formEnviarClick(event)
{
  event.preventDefault();
  console.log("formENviarClick");
  console.log(event);
  console.log(event.target);
  
  let name = document.getElementById("formName").value;
  console.log(name);
  let surname = document.getElementById("formSurname").value;
  console.log(surname);
  let person = {name: name
               , surname: surname}
  console.log(person);
  
  localStorage.setItem("personJSON", JSON.stringify(person));
}

function formObtenerDatos(event)
{
  event.preventDefault();
  console.log("formObtenerDatos");
  console.log(event);
  console.log(event.target);
  
  let personObject = JSON.parse(
          localStorage.getItem("personJSON"));
  
  console.log("person desde el localstorage")
  console.log(personObject);
  
  let nameInput = document.getElementById("formName")
  nameInput.value = personObject.name;
  let surnameInput = document.getElementById("formSurname")
  surnameInput.value = personObject.surname;
  
}
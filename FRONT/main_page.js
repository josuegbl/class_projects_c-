function loginPage(event)
{
  event.preventDefault();
  console.log("loginPage");
  console.log(event);
  console.log(event.target);
  
  let personObject = JSON.parse(
          localStorage.getItem("personJSON"));
  
  console.log("person desde el localstorage");
  console.log(personObject);
  
  let emailInput = document.getElementById("formEmail");

  let passInput = document.getElementById("formPasswd");

  if(personObject.email == emailInput.value 
     && personObject.passwd == passInput.value)
  {
    console.log("Paso el if");
    
    window.location.href = "form_crud.html";
    console.log(window.location.href);
  }

}



function change(value)
{
  console.log(value);
  
  return document.getElementById(value).innerHTML = window.location.href;
}
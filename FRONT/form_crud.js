const personHandler = (event) => {
  event.preventDefault();
  console.log("formSendClick");
  // console.log(event);
  // console.log(event.target);
  
  let person = {name: document.getElementById("formName").value
              , surname: document.getElementById("surnames").value
              , datebirth: document.getElementById("birthDate").value
              , email: document.getElementById("formEmail").value
              , passwd: document.getElementById("passwd").value}
  console.log(person);

  localStorage.setItem("personJSON", JSON.stringify(person));
}

const onDOMLoad = () => {
  document.getElementById("submit").addEventListener("click", personHandler)
}



document.addEventListener("DOMContentLoaded", onDOMLoad)
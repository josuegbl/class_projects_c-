function formSendClick(event)
{
  event.preventDefault();
  console.log("formSendClick");
  console.log(event);
  console.log(event.target);
  
  let name = document.getElementById("name").value;
  console.log(name);
  let surname = document.getElementById("surnames").value;
  console.log(surname);
  let person = {name: name
              , surname: surname}
  console.log(person);
  
  localStorage.setItem("personJSON", JSON.stringify(person));
}

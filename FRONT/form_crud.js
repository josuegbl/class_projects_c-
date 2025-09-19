function formSendClick(event)
{
  event.preventDefault();
  console.log("formSendClick");
  // console.log(event);
  // console.log(event.target);
  
  let name = document.getElementById("formName").value;
  console.log(name);

  let surname = document.getElementById("surnames").value;
  console.log(surname);

  let birthdate = document.getElementById("birthDate").value;
  console.log(birthdate);

  let email = document.getElementById("formEmail").value;
  console.log(email);

  let passwd = document.getElementById("passwd").value;
  console.log(passwd);


  let person = {name: name
              , surname: surname
              , datebirth: birthdate
              , email: email
              , passwd: passwd}
  console.log(person);

  localStorage.setItem("personJSON", JSON.stringify(person));
}



const writedata = (value) => {
    let input = document.createElement("input");
    input.setAttribute('type', 'text')
    input.setAttribute('class', "form-control ")
    input.setAttribute('value',value)
    input.setAttribute('disabled','')
    input.setAttribute('readonly','')
}

const onDOMLoad = () => {
    console.log("aqui!")
    const person = localStorage.getItem(JSON.parse(localStorage.getItem("personJSON")));

    for (const [key, value] of Object.entries(person)) {
        writedata(value)
        let parent = document.getElementById("parent");
        parent.appendChild(input);
    }
    let body = document.querySelector('body')
    body.appendChild(personParent)
    
    document.body.innerHTML.replace = body
    
}

document.addEventListener("DOMContentLoaded", onDOMLoad)

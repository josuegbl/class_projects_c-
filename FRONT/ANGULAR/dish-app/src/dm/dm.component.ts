import { Component, EventEmitter, Input, OnChanges, Output, SimpleChanges } from '@angular/core';

@Component({
  selector: 'dish-dm',
  imports: [],
  templateUrl: './dm.component.html',
  styleUrl: './dm.component.css'
})
export class DmComponent implements OnChanges{
  @Output() dishesUpdated = new EventEmitter();
  @Input() newDish: object = {};
  @Input() dishId: string = "";
  
  dishes: any = [];
  constructor()  {
    console.log("constructor en DISH-DM")
    this.fetchDishes();
  }


  fetchDishes() {
    let xhr = new XMLHttpRequest();

    xhr.addEventListener("readystatechange",
       (event) => {
        let xhrResponse = <XMLHttpRequest>event.target;
        if (xhrResponse.readyState === 4 && xhrResponse.status === 200)
        {
          console.log("Got dishes")
          console.log(xhrResponse);

          this.dishes = JSON.parse(xhrResponse.responseText);

          this.dishes.forEach(
            (element: {image: {src: string; }; }) => {
              element.image = {
                src: "chuleton-de-ternera.jpg"
              }
            });

          console.log(this.dishes);


          this.dishesUpdated.emit(
            {
              dishes: this.dishes
            }
          )
        }

       }
  )

    xhr.open("GET", "http://localhost:5227/api/dishes")
    xhr.send();
  }

  ngOnChanges(changes: SimpleChanges): void {
    console.log("ngOnchanges en el DM")
    console.log(changes);

    if(changes['newDish']?.previousValue !== undefined)
    {
      this.createDish(changes['newDish'].currentValue);
    }
    if(changes['dishId']?.previousValue !== undefined)
      {
        this.createDish(changes['dishId'].currentValue);
      }
    }


  createDish(dish: any)
  {
    console.log("createDish");
    console.log(dish);

    let xhr = new XMLHttpRequest();

    xhr.addEventListener("readystatechange",
       (event) => 
        {
          let xhrResponse = <XMLHttpRequest>event.target;
          if (xhrResponse.readyState === 4 && xhrResponse.status === 200)
          {
            console.log("created Dish")
            console.log(xhrResponse.responseText);
            this.fetchDishes();
          }
        }
  )

    xhr.open("POST", "http://localhost:5227/api/dishes");
    xhr.setRequestHeader("Content-Type", "application/json");
    xhr.send(JSON.stringify(dish));

  }

  remove(id: string)
  {
    console.log("remove Dish");
    console.log(id);

    let xhr = new XMLHttpRequest();

    xhr.addEventListener("readystatechange",
       (event) => 
        {
          let xhrResponse = <XMLHttpRequest>event.target;
          if (xhrResponse.readyState === 4 && xhrResponse.status === 200)
          {
            console.log("created Dish")
            console.log(xhrResponse.responseText);
            this.fetchDishes();
          }
        }
  )

    xhr.open("DELETE", `http://localhost:5227/api/dishes/${id}`);
    xhr.send();

  }

}


//  dishes: any = [];

//   constructor() {
   
//   this.dishes = [{
//     id:   "1"
//   , name: "Plato1"
//   , price: 20
//   , image: {
//            src: "chuleton-de-ternera.jpg"
//            }
//  }, {
//    id:   "2"

//    , name: "Plato2"
//    , price: 30
//    , image: {
//             src: "chuleton-de-ternera.jpg"
//             }
//  }, {
//      id:   "1"
//    , name: "Plato3"
//    , price: 40
//    , image: {
//             src: "chuleton-de-ternera.jpg"
//             }
//  }];


//  setTimeout(
//       ()  => {  
//                 this.dishesUpdated.emit(
//                   {
//                   dishes: this.dishes
//                   }
//                   )
//               }, 1000);
//   }
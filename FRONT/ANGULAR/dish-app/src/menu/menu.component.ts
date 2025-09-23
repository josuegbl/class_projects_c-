import { Component } from '@angular/core';
import { MenuItemComponent } from "../menu-item/menu-item.component";

@Component({
  selector: 'dish-menu',
  imports: [MenuItemComponent],
  templateUrl: './menu.component.html',
  styleUrl: './menu.component.css'
})
export class MenuComponent {

  dishes: any = [
    {
       id:   "1"
     , name: "Plato1"
     , price: 20
     , image: {
              src: "chuleton-de-ternera.jpg"
              }
    }, {
      id:   "2"

      , name: "Plato2"
      , price: 30
      , image: {
               src: "chuleton-de-ternera.jpg"
               }
    }, {
        id:   "1"
      , name: "Plato3"
      , price: 40
      , image: {
               src: "chuleton-de-ternera.jpg"
               }
    }
];

createDish(){
  console.log("createDish");
  let dishName = (<HTMLInputElement>document.getElementById("dishName"))!.value;
  console.log("nombre: " + dishName);
  let dishPrice = (<HTMLInputElement>document.getElementById("dishPrice"))!.value;
  console.log("precio: " + dishPrice);

this.dishes.push(
  {
    id: this.dishes.length - 1
  , name: dishName
  , price: dishPrice
  , image: {
    src: "chuleton-de-ternera.jpg"
  }
  }
)

}



}

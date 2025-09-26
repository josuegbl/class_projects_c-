import { Component, Input, input } from '@angular/core';
import { MenuItemComponent } from "../menu-item/menu-item.component";
import { DmComponent } from '../dm/dm.component';

@Component({
  selector: 'dish-menu',
  imports: [MenuItemComponent, DmComponent],
  templateUrl: './menu.component.html',
  styleUrl: './menu.component.css'
})
export class MenuComponent {
  @Input() showDiv: any;

  dishes: any = [];
  newDish: any = {};




createDish(){
  console.log("createDish");

  let dishName = (<HTMLInputElement>document.getElementById("dishName"))!.value;
  console.log("nombre: " + dishName);

  let dishPrice = (<HTMLInputElement>document.getElementById("dishPrice"))!.value;
  console.log("precio: " + dishPrice);

  // this.dishes = [
  //   ...this.dishes // spread syntax
  //   , {
  //     id: this.dishes.length - 1
  //     , name: dishName
  //     , price: dishPrice
  //     , image: {
  //       src: "chuleton-de-ternera.jpg"
  //              }
  
  //   }
  // ]
// alternative
//   this.dishes.push(
//     {
//       id: this.dishes.length - 1
//     , name: dishName
//     , price: dishPrice
//     , image: {
//       src: "chuleton-de-ternera.jpg"
//     }
//     }
// )

  let newDish: any = {
    id: (this.dishes.length + 1).toString()
  , name: dishName
  , price: Number.parseFloat(dishPrice)
  }
  this.newDish = newDish;


  // this.dishes.push(
  //   {
  //     id: this.dishes.length - 1
  //   , name: dishName
  //   , price: dishPrice
  //   , image: {
  //     src: "chuleton-de-ternera.jpg"
  //   }
  //   }
// )

}

dishesUpdated(event: any) {
  console.log("dishesUpdated AQUI");
  console.log(event);
  
  this.dishes = event.dishes;
}


}

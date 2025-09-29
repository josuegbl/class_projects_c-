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
  @Input() isMenu: boolean = true;

  dishes: any = [];
  newDish: any = {};
  dishId: string = "";

  constructor()  {
    console.log("constructor en MENU Component")
    // this.showDiv = {menu: true};
  }

createDish(){
  console.log("createDish");

  let dishName = (<HTMLInputElement>document.getElementById("dishName"))!.value;
  console.log("nombre: " + dishName);

  let dishPrice = (<HTMLInputElement>document.getElementById("dishPrice"))!.value;
  console.log("precio: " + dishPrice);

  let newDish: any = 
  {
    id: (this.dishes.length + 1).toString()
  , name: dishName
  , price: Number.parseFloat(dishPrice)
  }
  this.newDish = newDish;
  
  window.location.reload();

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

remove(event: any)
{
  this.dishId = event;
}

dishesUpdated(event: any) {
  console.log("dishesUpdated AQUI");
  console.log(event);
  
  this.dishes = event.dishes;
}


}

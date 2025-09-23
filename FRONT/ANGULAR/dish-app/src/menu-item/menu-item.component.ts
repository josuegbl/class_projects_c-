import { UpperCasePipe } from '@angular/common';
import { Component, Input } from '@angular/core';
import { IDish } from './dish.model';
import { NgClass } from "../../node_modules/@angular/common/common_module.d-NEF7UaHr";

@Component({
  selector: 'dish-menu-item',
  imports: [UpperCasePipe, NgClass],
  templateUrl: './menu-item.component.html',
  styleUrl: './menu-item.component.css'
})

export class MenuItemComponent {
  @Input({required: true}) dish: any;


//   showMessage(dish: any, event: any) {
//     console.log("ShoMessage");
// //    console.log(event);
// //    console.log(event.target.innerText);
    
//     document.getElementById("messageDiv")!.textContent = 
//     event.target.innerText + " es barato ¡ compra! el plato" 
//     + dish.name;
//   }

//   onSale() {
//     console.log("On Sale")
//     this.dish.price = 14;
//   }
}


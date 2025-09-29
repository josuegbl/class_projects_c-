import { UpperCasePipe } from '@angular/common';
import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'dish-menu-item',
  imports: [UpperCasePipe],
  templateUrl: './menu-item.component.html',
  styleUrl: './menu-item.component.css'
})

export class MenuItemComponent {
  @Output() removeDish = new EventEmitter();
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

remove()
{
  let id = this.dish.id;
  console.log("borrando " + this.dish.id)
  // this.dish
  // window.location.reload();

  this.removeDish.emit(id);
}

}


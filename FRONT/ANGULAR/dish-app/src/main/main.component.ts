import { Component } from '@angular/core';
import { MenuComponent } from "../menu/menu.component";

@Component({
  selector: 'dish-main',
  imports: [MenuComponent],
  templateUrl: './main.component.html',
  styleUrl: './main.component.css'
})
export class MainComponent {
  showDiv: any = 
  {
    menu: true
  , create: false
  };


  constructor() 
  {
    console.log("Esto es su valor: " + this.showDiv.menu)
  }

  showMenu(event: any) {
   console.log("showMenu");
   console.log(event);
   this.showDiv = 
   {
    menu: true
  , create: false
   };

  }

  showCreateDish(event: any) {
    console.log("showCreateDish");
   console.log(event);
   this.showDiv = 
   {
    menu: false
  , create: true
   };
  }

}

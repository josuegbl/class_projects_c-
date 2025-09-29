import { Component } from '@angular/core';
import { MenuComponent } from "../menu/menu.component";
import { DmComponent } from '../dm/dm.component';

@Component({
  selector: 'dish-main',
  imports: [MenuComponent],
  templateUrl: './main.component.html',
  styleUrl: './main.component.css'
})
export class MainComponent {
  isMenu: boolean = true 
  dishes: any = [];

  constructor() 
  {
    console.log("COnstructor MAIN Esto es su valor: " + this.isMenu)
  }

  showMenu(event: any) {
   console.log("showMenu");
   console.log(event);
   window.location.reload();

  }

  showCreateDish(event: any) {
    console.log("showCreateDish");
   console.log(event);
   this.isMenu = false
   };
}

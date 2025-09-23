import { Component } from '@angular/core';
import { MenuComponent } from "../menu/menu.component";

@Component({
  selector: 'dish-main',
  imports: [MenuComponent],
  templateUrl: './main.component.html',
  styleUrl: './main.component.css'
})
export class MainComponent {

}

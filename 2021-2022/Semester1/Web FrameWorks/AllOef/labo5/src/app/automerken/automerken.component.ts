import { Component, OnInit } from '@angular/core';
import { CarManufacturer } from './manufacturers';


@Component({
  selector: 'app-automerken',
  templateUrl: './automerken.component.html',
  styleUrls: ['./automerken.component.css']
})
export class AutomerkenComponent implements OnInit {

  manufacturers: CarManufacturer[] = [];

  constructor() {
    this.manufacturers.push(new CarManufacturer("Ford", "Kuga", "B-Max", "S-Max", "Focus", "Mondeo"));
    this.manufacturers.push(new CarManufacturer("Mercedes", "C-220", "E-250"));
    this.manufacturers.push(new CarManufacturer("BMW", "X-3", "X-6", "322"));
   }

  ngOnInit(): void {
  }

}

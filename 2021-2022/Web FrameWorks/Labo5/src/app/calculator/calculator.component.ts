import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent implements OnInit {

  counter : number = 0;
  x : number = 0 ; 
  y : number = 0 ;
  cordinates : string = ""

  constructor() { }

  ngOnInit(): void {
  }

  increment = () =>{
     return this.counter++;
  } 

  DoSomething = (info : MouseEvent) => {
    this.x = info.offsetX 
    this.y = info.offsetY
    this.cordinates = `${this.x}/${this.y}`
    console.log("x = " + this.x + "y = " + this.y) 
  }

  FillText = () =>{
    return this.cordinates;
  }

}

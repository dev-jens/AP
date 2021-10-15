import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-randint',
  templateUrl: './randint.component.html',
  styleUrls: ['./randint.component.css']
})
export class RandintComponent implements OnInit {

  public num : number = Math.floor(Math.random() * (100 - 0 + 1)) + 0;

  getRandomInt(min : number, max : number) : number{
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min; 
  }

  constructor() {
    setInterval(() =>{
      this.num =  this.getRandomInt(0,100);
    },2000)
   }

  ngOnInit(): void {
  }

}

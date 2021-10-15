import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-random-score',
  templateUrl: './random-score.component.html',
  styleUrls: ['./random-score.component.css']
})
export class RandomScoreComponent implements OnInit {

  public num : number = Math.floor(Math.random() * (10 - 0 + 1)) + 0;

  getRandomInt(min : number, max : number) : number{
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min; 
  }

  constructor() {
    setInterval(() =>{
      this.num =  this.getRandomInt(0,10);
    },2000)
   }

  ngOnInit(): void {
  }

}

import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-redbox',
  templateUrl: './redbox.component.html',
  styleUrls: ['./redbox.component.css']
})
export class RedboxComponent implements OnInit {


  x : number = 0;
  y: number = 0;

  constructor() { }

  ngOnInit(): void {
  }

  DoSomething(event: MouseEvent): void {

    this.x = event.offsetX;
    this.y = event.offsetY;
    console.log("X = " + this.x, "Y = " + this.y);

  }

}

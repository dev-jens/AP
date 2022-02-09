import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-counter',
  templateUrl: './counter.component.html',
  styleUrls: ['./counter.component.css']
})
export class CounterComponent implements OnInit {

  public counter : number = 0;

  constructor() {
    setInterval(() => {
      this.counter++;
    },200)
   }

  ngOnInit(): void {
  }

}

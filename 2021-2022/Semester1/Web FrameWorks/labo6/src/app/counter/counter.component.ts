import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-counter',
  templateUrl: './counter.component.html',
  styleUrls: ['./counter.component.css']
})
export class CounterComponent implements OnInit {


  counter: number = 0;

  constructor() { }

  ngOnInit(): void {
  }


  Increment(){
    this.counter++;
  }

  submit(counter: number): void {
    this.counter = counter
  }

}

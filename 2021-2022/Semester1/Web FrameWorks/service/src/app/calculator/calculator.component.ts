import { Component, OnInit } from '@angular/core';
import { MyShareServiceService } from '../services/my-share-service.service';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent implements OnInit {


  
  
  constructor(private service: MyShareServiceService) { }

  ngOnInit(): void {
  }

  setCounter(num:string): void
  { 
    this.service.counter = parseInt(num)
  }

  get counter(){
    return this.service.counter
  }

}

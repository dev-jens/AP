import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-time',
  templateUrl: './time.component.html',
  styleUrls: ['./time.component.css']
})
export class TimeComponent implements OnInit {


  public datum : Date = new Date();

  constructor() {

    setInterval(() =>{this.datum = new Date} , 1000)

   }

  ngOnInit(): void {
  }

}

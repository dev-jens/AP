import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-current-time',
  templateUrl: './current-time.component.html',
  styleUrls: ['./current-time.component.css']
})
export class CurrentTimeComponent implements OnInit {

  public today :number = Date.now();


  constructor() 
  {
    setInterval(() => { this.today = Date.now() } , 1000)
  }

  ngOnInit(): void {
  }



}

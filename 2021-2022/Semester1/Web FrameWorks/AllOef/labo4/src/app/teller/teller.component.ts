import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-teller',
  templateUrl: './teller.component.html',
  styleUrls: ['./teller.component.css']
})
export class TellerComponent implements OnInit {

  teller:number = 0;

  constructor() { 
    setInterval(() =>{this.teller++}, 200)
  }

  ngOnInit(): void {
  }

}

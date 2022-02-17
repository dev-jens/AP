import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-welkomstcomponent',
  templateUrl: './welkomstcomponent.component.html',
  styleUrls: ['./welkomstcomponent.component.css']
})
export class WelkomstcomponentComponent implements OnInit {


  datum: Date;

  constructor() {
    
    setInterval(() => this.datum = new Date(), 1000)

  }

  get IsMorining(): boolean {

    return this.datum.getHours() < 12;

  }

  get IsEvening(): boolean {

    return this.datum.getHours() >= 18;

  }
  

  ngOnInit(): void {
  }

}

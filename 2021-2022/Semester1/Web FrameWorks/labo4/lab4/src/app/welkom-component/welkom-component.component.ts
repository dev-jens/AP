import { Component, OnInit } from '@angular/core';
@Component({
  selector: 'app-welkom-component',
  templateUrl: './welkom-component.component.html',
  styleUrls: ['./welkom-component.component.css']
})
export class WelkomComponentComponent implements OnInit {

  public now :number = Date.now();
  
  constructor() {
    setInterval(() => { this.now = Date.now() } , 1000)
  }

  ngOnInit(): void {
  }
}

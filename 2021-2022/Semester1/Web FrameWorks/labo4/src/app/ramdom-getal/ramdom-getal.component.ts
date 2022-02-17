import { Component, OnInit } from '@angular/core';
import * as _ from 'lodash';
@Component({
  selector: 'app-ramdom-getal',
  templateUrl: './ramdom-getal.component.html',
  styleUrls: ['./ramdom-getal.component.css']
})
export class RamdomGetalComponent implements OnInit {


  ramdomNumber : number;

  constructor() { 

    setInterval(() =>{this.ramdomNumber = _.random(0, 100)}, 1000)

  }

  ngOnInit(): void {
  }

}

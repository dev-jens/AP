import { Component, OnInit } from '@angular/core';
import * as _ from 'lodash';
@Component({
  selector: 'app-willekeurig-getal',
  templateUrl: './willekeurig-getal.component.html',
  styleUrls: ['./willekeurig-getal.component.css']
})
export class WillekeurigGetalComponent implements OnInit {

  score: Number;

  constructor() { 

    setTimeout(() => {this.score = _.random(0, 10)},2000)
    setInterval(() =>{this.score = _.random(0, 10)}, 2000)

  }

  // get Score(): number {
  //   return this.score = _.random(0,10)
  // }

  ngOnInit(): void {
  }

}

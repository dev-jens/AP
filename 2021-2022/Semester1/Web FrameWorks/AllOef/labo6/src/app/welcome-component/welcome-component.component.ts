import { Component, OnInit } from '@angular/core';
import * as _ from 'lodash';

@Component({
  selector: 'app-welcome-component',
  templateUrl: './welcome-component.component.html',
  styleUrls: ['./welcome-component.component.css']
})
export class WelcomeComponentComponent implements OnInit {

  
  rdn:number = _.random(152);
  imageUrl: string = `https://mdbootstrap.com/img/Photos/Slides/img%20(${this.rdn}).jpg`;


  constructor() {

    setInterval(() =>{
      this.rdn =  _.random(152);
      this.imageUrl = `https://mdbootstrap.com/img/Photos/Slides/img%20(${this.rdn}).jpg`
  
    },5000);

   }

  ngOnInit(): void {
  }

}

import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-welcome-component',
  templateUrl: './welcome-component.component.html',
  styleUrls: ['./welcome-component.component.css']
})
export class WelcomeComponentComponent implements OnInit {
  
  
  getRandomInt = (min :number, max:number) :number =>{ 
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min; 
  }

  imgUrl : String =  `https://mdbootstrap.com/img/Photos/Slides/img%20(${this.getRandomInt(1,152)}).jpg`;
  imgUrl2 : String =  `https://mdbootstrap.com/img/Photos/Slides/img%20(${this.getRandomInt(1,152)}).jpg`;
  constructor() {

    setInterval(()=>{
      this.imgUrl =  `https://mdbootstrap.com/img/Photos/Slides/img%20(${this.getRandomInt(1,152)}).jpg`
      this.imgUrl2 = `https://mdbootstrap.com/img/Photos/Slides/img%20(${this.getRandomInt(1,152)}).jpg`;
    },5000)
    
   }

  ngOnInit(): void {
  }
}

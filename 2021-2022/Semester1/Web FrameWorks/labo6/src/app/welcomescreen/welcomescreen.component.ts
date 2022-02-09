import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-welcomescreen',
  templateUrl: './welcomescreen.component.html',
  styleUrls: ['./welcomescreen.component.css']
})
export class WelcomescreenComponent implements OnInit {

  getRandomInt = (min :number, max:number) :number =>{ 
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min; 
  }
 

  array : number[] = [];
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

   
  fillArray = (arr : number[]): number[] => {
    for (let i = 0; i< 153; i++) {
      arr[i] = i
    }
    return arr;
  }

}

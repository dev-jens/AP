import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class WelcomeComponentService {


  foto = 1;
  arr:String[] = []
  
  imageURL:String = `https://mdbootstrap.com/img/Photos/Slides/img%20(${this.foto}).jpg`;
 

  constructor() { 
    for (let i = 1; i < 153; i++) {
      this.arr.push( "https://mdbootstrap.com/img/Photos/Slides/img%20("+i+").jpg")
    }
  }
}

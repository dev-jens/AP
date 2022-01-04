import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-welcome-component',
  templateUrl: './welcome-component.component.html',
  styleUrls: ['./welcome-component.component.css']
})
export class WelcomeComponentComponent implements OnInit {


  foto = 1;
  listNum:String[] = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "10"]


  constructor() { 

    setInterval(() =>{console.log(this.foto);}, 1000)
    

  }

  ngOnInit(): void {
  }

  get imageURL()
  {
    return `https://mdbootstrap.com/img/Photos/Slides/img%20(${this.foto}).jpg`  
  }



}

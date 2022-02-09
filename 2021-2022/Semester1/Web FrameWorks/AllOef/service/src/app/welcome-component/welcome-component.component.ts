import { Component, OnInit } from '@angular/core';
import { WelcomeComponentService } from '../services/welcome-component.service';

@Component({
  selector: 'app-welcome-component',
  templateUrl: './welcome-component.component.html',
  styleUrls: ['./welcome-component.component.css']
})
export class WelcomeComponentComponent implements OnInit {

  constructor(private service: WelcomeComponentService) { }

  ngOnInit(): void {
  }

  get imageURL() {
    return this.service.imageURL
  }
  set imageURL(url:String) {
    this.service.imageURL =url
  }

  get listNum(){
    return this.service.arr
  }

}

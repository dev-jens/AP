import { Component, OnInit } from '@angular/core';
import { WelcomeComponentService } from '../services/welcome-component.service';

@Component({
  selector: 'app-welcome-select-component',
  templateUrl: './welcome-select-component.component.html',
  styleUrls: ['./welcome-select-component.component.css']
})
export class WelcomeSelectComponentComponent implements OnInit {

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

import { Component, OnInit } from '@angular/core';
import * as moment from "moment";
@Component({
  selector: 'app-started-ago',
  templateUrl: './started-ago.component.html',
  styleUrls: ['./started-ago.component.css']
})
export class StartedAgoComponent implements OnInit {

  started : number = 0;
  constructor() {
    setInterval(()=>{
      moment().set('minute', this.started++);
    },60000)
   }

  ngOnInit(): void {
  }

}

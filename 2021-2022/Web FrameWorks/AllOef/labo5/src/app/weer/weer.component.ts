import { Component, OnInit } from '@angular/core';
import * as _  from 'lodash';

@Component({
  selector: 'app-weer',
  templateUrl: './weer.component.html',
  styleUrls: ['./weer.component.css']
})
export class WeerComponent implements OnInit {


  locations = ['Anchorage', 'Brussel', 'Osaka', 'Auckland', 'Kaapstad']
  temps: number[] = [5, 1, 10, 12, 18];

  constructor() {
    setInterval(this.Regenerate, 2000)
  }


  Regenerate = () =>
  {
    for(let t = 0; t < this.temps.length; t++)
    {
      this.temps[t] = _.random(25);
    }
  }

  ngOnInit(): void {
  }

}

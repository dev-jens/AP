import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-locations',
  templateUrl: './locations.component.html',
  styleUrls: ['./locations.component.css']
})
export class LocationsComponent implements OnInit {


  locations:String[] = ["AP hogeschool", "Eifel toren", "Statue of liberty", "Golden Gate Bridge"]
  
  constructor() { }

  ngOnInit(): void {
  }

}

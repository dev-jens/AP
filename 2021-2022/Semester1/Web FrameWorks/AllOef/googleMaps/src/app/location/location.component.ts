import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-location',
  templateUrl: './location.component.html',
  styleUrls: ['./location.component.css']
})
export class LocationComponent implements OnInit {

  title = 'Maps';
  lat = 51.678418;
  lng = 7.809007;
  locations:string[] = ["AP Hogeschool","Statue of Liberty","Eiffel Tower","Golden Gate Bridge"]
  coordinates = [ "51.230193;4.413937",
                  "40.689247;-74.044502",
                  "48.858426703737166;2.2944672680728035",
                  "37.82019128931757;-122.47824436360415"]

  constructor(private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe(params => {
      params.get("location")
         this.change(this.locations.indexOf(params.get("location")!))
       })
     }
  
  change(i :number) : void {
    console.log(i)
    this.title = this.locations[i];
    this.lat = parseFloat(this.coordinates[i].split(";")[0])
    this.lng = parseFloat(this.coordinates[i].split(";")[1])
  }
}

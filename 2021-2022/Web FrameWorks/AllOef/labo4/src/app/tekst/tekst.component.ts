import { Component, OnInit } from '@angular/core';
import * as moment from "moment"
// Door deze import toe te voegen worden alle boodschappen van moment in het nederlands weergegeven
// zonder deze import worden de teksten in het Engels weergegeven. 
import 'moment/locale/nl';

@Component({
  selector: 'app-tekst',
  templateUrl: './tekst.component.html',
  styleUrls: ['./tekst.component.css']
})
export class TekstComponent implements OnInit {


  message: string;
  //we noteren de starttijd, zodat we steeds kunnen bepalen hoelang geleden deze werd gestart
  start : Date = new Date();

  constructor() { 

    
    this.UpdateMessage();
    setInterval(this.UpdateMessage, 1000)

  }

  UpdateMessage = () => {
    //De fromNow functie van moment.js zal een boodschap geven hoelang geleden de gegeven datum 
    //is ten opzicht van nu.
    this.message = moment(this.start).fromNow();
   }


  ngOnInit(): void {
  }

}

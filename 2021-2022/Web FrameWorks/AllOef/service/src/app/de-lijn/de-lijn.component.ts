import { Component, OnInit } from '@angular/core';
import { DeLijnService } from '../services/de-lijn.service';



@Component({
  selector: 'app-de-lijn',
  templateUrl: './de-lijn.component.html',
  styleUrls: ['./de-lijn.component.css']
})
export class DeLijnComponent implements OnInit {


  public halte:any = [];

  constructor(private service: DeLijnService) { }

  get bestemmingen()
  {

    return this.halte.halteDoorkomsten[0].doorkomsten
  }

  ngOnInit(): void {

    this.service.getHaleteInfo("200144").subscribe(res => this.halte = res)
  }

  
  // setInfo(info :any): void {

  //   this.halte = info;
  //   console.log(info.halteDoorkomsten[0].doorkomsten);
  //   console.log()
  //   // for (let i = 0; i < 5; i++) {
  //   //   console.log(this.halte.halteDoorkomsten[0].doorkomsten[i].bestemming)
  //   //   console.log(this.halte.halteDoorkomsten[0].doorkomsten[i].lijnnummer)
  //   //   console.log(this.halte.halteDoorkomsten[0].doorkomsten[i].dienstregelingTijdstip)
  //   // }

  // }


}

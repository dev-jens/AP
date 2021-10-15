import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-het-weer',
  templateUrl: './het-weer.component.html',
  styleUrls: ['./het-weer.component.css']
})
export class HetWeerComponent implements OnInit {

  public graden : number[] = [4,9,12,15,19,22,25];

  constructor() { }

  ngOnInit(): void {
  }

}

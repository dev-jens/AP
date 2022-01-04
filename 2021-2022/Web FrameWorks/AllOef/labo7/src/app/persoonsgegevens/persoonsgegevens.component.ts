import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-persoonsgegevens',
  templateUrl: './persoonsgegevens.component.html',
  styleUrls: ['./persoonsgegevens.component.css']
})
export class PersoonsgegevensComponent implements OnInit {

  person = {} as IPersonInfo;
  isPublished = false;

  constructor() { }

  ngOnInit(): void {
  }

  publish(): boolean {
    return this.isPublished = true;
  }


}

interface IPersonInfo
{
  Name: string;
  FirstName: string;
  Street: string;
  Number: string;
  City: string;
}


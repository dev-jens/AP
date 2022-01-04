import { Component, OnInit } from '@angular/core';
import { Person } from './Person';

@Component({
  selector: 'app-persoonsinformatie',
  templateUrl: './persoonsinformatie.component.html',
  styleUrls: ['./persoonsinformatie.component.css']
})
export class PersoonsinformatieComponent implements OnInit {


  people: Person[] = [];

  constructor() {

    this.people.push(new Person("Jens", "Baeten", new Date(2001, 4, 9)))
    this.people.push(new Person("Amber", "Gillard", new Date(2001,3, 3)))
    this.people.push(new Person("Yari", "Baeten", new Date(2003, 12, 7)))
  }

  ngOnInit(): void {
  }

}

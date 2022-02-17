import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-todo-lijst',
  templateUrl: './todo-lijst.component.html',
  styleUrls: ['./todo-lijst.component.css']
})
export class TodoLijstComponent implements OnInit {

  title: string = 'Todo Lijst'
  itemLijst : String[] = ["huiswerk", "examen", "kuisen"];
  

  constructor() { }

  ngOnInit(): void {
  }

  IsEmpty(): boolean {
     return this.itemLijst.length == 0;
  }


  addItem(item: string){
    this.itemLijst.push(item)

  }

  Verwijder(index: number): void {

    this.itemLijst.splice(index, 1)
    console.log(index)
    console.log(this.itemLijst.length)

  }

}

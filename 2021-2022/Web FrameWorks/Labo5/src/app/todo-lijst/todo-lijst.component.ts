import { Component, OnInit } from '@angular/core';



@Component({
  selector: 'app-todo-lijst',
  templateUrl: './todo-lijst.component.html',
  styleUrls: ['./todo-lijst.component.css']
})
export class TodoLijstComponent implements OnInit {

  list : string[] = ['Webframeworks maken', "kassen" ,"schoonmaken"];
  
  constructor() { }

  ngOnInit(): void {
  }

  IsEmpty(){
    return this.list.length == 0;
  }

  addTask(task : string){
    let button = <HTMLButtonElement> document.getElementById('btn');
    if(task == ""){
      button.disabled = true
      return;
    }
    else{
      button.disabled = false;
      this.list.push(task)
      console.log(task)
    }
  
    
    
  }
  
  removeTask(toDel : number){
    if (toDel > -1) {
     this.list.splice(toDel, 1);
}
  }

}

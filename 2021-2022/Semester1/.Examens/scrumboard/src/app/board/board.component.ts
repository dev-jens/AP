import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { IStoryboard, MyServiceService } from '../Service/my-service.service';
@Component({
  selector: 'app-board',
  templateUrl: './board.component.html',
  styleUrls: ['./board.component.css']
})
export class BoardComponent implements OnInit {
  board:IStoryboard[]=[]
  todo:IStoryboard[]=[]
  inProgress:IStoryboard[]=[]
  Done:IStoryboard[]=[]
  constructor(private svc:MyServiceService) { }

  async ngOnInit() {
    this.board = await this.svc.GetStoryboard()
    
  }

  ChangeTodo(todoitem){

  }
  Changeprogress(progresitem){
    
  }



 


}

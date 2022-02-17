import { Component, OnInit } from '@angular/core';
import { IStoryboard, TodoService } from '../services/todo.service';

@Component({
  selector: 'app-board',
  templateUrl: './board.component.html',
  styleUrls: ['./board.component.css']
})
export class BoardComponent implements OnInit {

  constructor(private todoSrv : TodoService) { 
    this.getboard();
  }

  board : IStoryboard[] = [];
  inprogress : IStoryboard[] = []

  // werken met eeen click event die dan een psuh zal doen van board naar in progress en dan een delete op in progress.

  async getboard(){ this.board = await this.todoSrv.storyboard}


  async ngOnInit() {
  }
}

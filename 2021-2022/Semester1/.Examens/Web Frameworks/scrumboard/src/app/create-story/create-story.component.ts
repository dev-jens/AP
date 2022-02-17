import { Component, OnInit } from '@angular/core';
import { IStorypoint, TodoService } from '../services/todo.service';

@Component({
  selector: 'app-create-story',
  templateUrl: './create-story.component.html',
  styleUrls: ['./create-story.component.css']
})
export class CreateStoryComponent implements OnInit {

  constructor(private todoSrv: TodoService) {
    this.getPoints();
   }

   points:IStorypoint[] = []
   async getPoints(){ this.points = await this.todoSrv.storypoints ;console.log(this.points.length)}

  Title : String = "";
  prio: boolean = true;
  estimation : string = "";
  teller:number = 0;
  show : boolean = false;

  //   getStorypoints(){
  //    this._storypoints = this.todoSrv.storypoints;
  //    console.log("lengte?:  " + this.todoSrv.storypoints.length)
  //  }

   setPrio(prio:String) {
     if(prio == "true")
        this.prio = true;
      else
        this.prio = false;
   }
   add(){
     if(this.estimation == "13")
        this.prio = true;
     
     let story = {
      "title": `${this.Title}`,
      "estimation": parseInt(this.estimation),
      "state": 0,
      "priority": this.prio,
      "id": this.teller++
     }
    this.todoSrv.postStory(story);
    this.show = true;

    setTimeout(()=>{this.show = false}, 4000)

   }

  async ngOnInit() {
    
  }
}

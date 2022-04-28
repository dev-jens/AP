import { ThrowStmt } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { IStorypoint,IStoryboard, MyServiceService } from '../Service/my-service.service';

@Component({
  selector: 'app-create-story',
  templateUrl: './create-story.component.html',
  styleUrls: ['./create-story.component.css']
})
export class CreateStoryComponent implements OnInit {
title:string|null=null
Estimation:IStorypoint[]=[]

keuzenummer:number=0
priority:boolean=false
class:string=""
notificatie:boolean=false
  constructor(private svc:MyServiceService) { }

  async ngOnInit() {
    this.Estimation=await this.svc.GetStorypoint()
  }

  invoer(value:string){this.title=value}
  value(v:number){
    this.keuzenummer=v
    if(this.keuzenummer>=3){this.priority=true}
    if(this.keuzenummer==13 && this.priority==true){this.class="redborder"}
  }

  notification(){
    this.Strory()
    

    this.notificatie = true
    setTimeout(()=> this.notificatie = false, 4000)
    this.title=""
    this.priority=false


  }
  Strory()
  {
    await this.svc.AddStory(this.title, this.Estimation, this.priority)
  }


}


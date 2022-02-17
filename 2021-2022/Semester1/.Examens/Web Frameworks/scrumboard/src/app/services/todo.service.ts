import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TodoService {

  constructor(private _http : HttpClient) { 
    
  }


  get storypoints(){
    return this._http.get<IStorypoint[]>("http://localhost:3000/storypoints").toPromise();
  }

  get storyboard() {
    return this._http.get<IStoryboard[]>("http://localhost:3000/storyboard").toPromise();
  }



  async postStory(story : IStoryboard){
    await this._http.post<IStoryboard>("http://localhost:3000/storyboard" , story).toPromise()
  }



}
export interface IStorypoint {
  value: number;
}

export interface IStoryboard {
  title: string;
  estimation: number;
  state: number;
  priority: boolean;
  id: number;
}

export interface Istory {
  storypoints: IStorypoint[];
  storyboard: IStoryboard[];
}

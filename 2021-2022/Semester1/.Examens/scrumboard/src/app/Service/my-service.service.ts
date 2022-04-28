import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { title } from 'process';
@Injectable({
  providedIn: 'root'
})
export class MyServiceService {

  constructor(private http:HttpClient) { }

  async GetStorypoint(){
    return this.http.get<IStorypoint[]>(`http://localhost:3000/storypoint`).toPromise()
  }
  async GetStoryboard(){
    return this.http.get<IStoryboard[]>(`http://localhost:3000/storyboard`).toPromise()
  }
  async AddStory(Storytitle: string, Estimation: number, Priority: boolean){
    this.http.post<IStoryboard>(`http://localhost:3000/ShoppingList`, { title :Storytitle ,  estimation: Estimation, priority : Priority}).toPromise()
  }

}

export interface IStorypoint {
  value: number;
  
}

export interface IStoryboard {
  title: string,
  estimation: number,
  state: number,
  priority: boolean,
  id: number
}


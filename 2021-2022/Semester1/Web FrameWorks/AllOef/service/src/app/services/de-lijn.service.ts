import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class DeLijnService {

  constructor(private http: HttpClient) { }

  getHaleteInfo(haltenumber: string)
  {

     return this.http.get(`https://api.delijn.be/DLKernOpenData/api/v1/haltes/1/${haltenumber}/real-time`,{headers: {"Ocp-Apim-Subscription-Key": "ffc4c96e25114adaa4c6cb7a069bb97a"}})


  }
}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PokedataService {
  constructor(private _http : HttpClient) {
    this.getPokemons()
   }

  private _pokemons : Pokemon[] = [];

  get Pokemons(): Pokemon[]{
    return this._pokemons
  }

   async getPokemons(){
    let pokemon =  await this._http.get<Pokemon[]>("http://localhost:3000/pokemons").toPromise();
    this._pokemons = pokemon;
    
  }
  async post(pokemon: Pokemon){
    await this._http.post<Pokemon>("http://localhost:3000/pokemons", pokemon).toPromise();
  }

 
}
export interface Sprites {
  normal: string;
  animated: string;
}

export interface Pokemon {
  id: string;
  species_id: string;
  height: string;
  weight: string;
  base_experience: string;
  order: string;
  is_default: string;
  name: string;
  sprites: Sprites;
}

export interface RootObject {
  pokemons: Pokemon[];
}

import { Component, OnInit } from '@angular/core';
import { PokedataService, Pokemon } from '../services/pokedata.service';

@Component({
  selector: 'app-pokemon-list',
  templateUrl: './pokemon-list.component.html',
  styleUrls: ['./pokemon-list.component.css']
})
export class PokemonListComponent implements OnInit {

  constructor(private pokesrv: PokedataService) {
   }

  get pokemons() {
    return this.pokesrv.Pokemons
  }

  addPokemon(){
    let pokemonToadd = 
    {
      "id": "155",
      "species_id": "155",
      "height": "4",
      "weight": "40",
      "base_experience": "270",
      "order": "227",
      "is_default": "1",
      "name": "mewTHREER",
      "sprites": {
        "normal": "http://img.pokemondb.net/sprites/black-white/normal/mew.png",
        "animated": "http://img.pokemondb.net/sprites/black-white/anim/normal/mew.gif"
      }
    }
    this.pokesrv.post(pokemonToadd)

  }



  
  

  ngOnInit(): void {

  }

}

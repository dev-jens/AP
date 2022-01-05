import { Component, OnInit } from '@angular/core';
import  *  as  pokemons  from  '../pokemon.json';


@Component({
  selector: 'app-pokemon-list',
  templateUrl: './pokemon-list.component.html',
  styleUrls: ['./pokemon-list.component.css']
})
export class PokemonListComponent implements OnInit {


  pokemons = pokemons

  constructor() { }

 
  ngOnInit(): void {

  }
}



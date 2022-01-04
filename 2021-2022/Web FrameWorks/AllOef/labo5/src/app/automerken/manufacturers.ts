export class CarManufacturer
{
  Models: string[];
  //We gebruiken hier de rest parameter in de constructor
  //omdat het aantal modellen niet vastligt 
  constructor(public Name: string, ...models: string[])
  {
    this.Models = models;
  }
}

import { HttpClient } from '@angular/common/http';
import { typeWithParameters } from '@angular/compiler/src/render3/util';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private _products: Product[] = [];
  private _shoppingList: ShoppingList[] = [];

  get products(){
    return this._products;
  }
  
  set products(value: Product[]){
    this._products = value
  }

  set shoppingList(value: ShoppingList[]){
    this._shoppingList = value
  }

  get shoppingList() {
    return this._shoppingList;
  }


  async getProducts(){
    let products = await this._http.get<Product[]>("http://localhost:3000/Products").toPromise();
    this._products = products;
  }
  async getList(){
    let shoppingList = await this._http.get<ShoppingList[]>("http://localhost:3000/ShoppingList").toPromise();
    this._shoppingList = shoppingList ;
  }

  


  constructor(private _http: HttpClient) {
    this.getProducts();
    this.getList();
   }
}


export interface Product {
  Id: number;
  Name: string;
  Brand: string;
  Size: string;
  Price: number;
}

export interface ShoppingList {
  Name: string;
  Amount: number;
  Price: number;
  id: number;
}

export interface RootObject {
  Products: Product[];
  ShoppingList: ShoppingList[];
}

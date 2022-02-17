import { Component, OnInit } from '@angular/core';
import { ProductService, ShoppingList } from '../Services/product.service';

@Component({
  selector: 'app-show-list',
  templateUrl: './show-list.component.html',
  styleUrls: ['./show-list.component.css']
})
export class ShowListComponent implements OnInit {

  constructor(private productSrvc : ProductService) { }

  get shoppingList(): ShoppingList[] {
    return this.productSrvc.shoppingList
  }

  get price(){
    return this.productSrvc.shoppingList.map(p => p.Price * p.Amount).reduce((a, b) => a + b ,0)
  }
  
  remove(id : number){
    this.productSrvc.shoppingList = this.productSrvc.shoppingList.filter(p => p.id != id)
  }


  async ngOnInit() {
  }
}

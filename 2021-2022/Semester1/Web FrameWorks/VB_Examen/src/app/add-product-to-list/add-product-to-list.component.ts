import { Component, OnInit } from '@angular/core';
import { Product, ProductService, ShoppingList } from '../Services/product.service';

@Component({
  selector: 'app-add-product-to-list',
  templateUrl: './add-product-to-list.component.html',
  styleUrls: ['./add-product-to-list.component.css']
})
export class AddProductToListComponent implements OnInit {

  constructor(private productSrvc: ProductService) {}

  public id = "1";

  showNotifications = false;

  get products(): Product[] {
    return this.productSrvc.products;
  }

  addProduct(amount : string){
    
    if(this.productSrvc.shoppingList.find(p => p.id == parseInt(this.id))) {
     this.productSrvc.shoppingList.find(p => p.id === parseInt(this.id)).Amount += parseInt(amount);
    
    }else{
     let product = this.products.find(p => p.Id === parseInt(this.id)); 
 
     let productToAdd = {
      "Name": product.Name,
      "Amount": parseInt(amount),
      "Price": product.Price,
      "id": product.Id
     }
     this.productSrvc.shoppingList.push(productToAdd);
    }
    this.showNotifications = true; 
    setTimeout(() =>{this.showNotifications = false}, 2500)

   }
 

  async ngOnInit() {
  }
}

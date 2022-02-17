import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { AddProductToListComponent } from './add-product-to-list/add-product-to-list.component';
import { ShowListComponent } from './show-list/show-list.component';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    AppComponent,
    AddProductToListComponent,
    ShowListComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      {
        path: "add",
        component: AddProductToListComponent
      },
      {
        path: "summary",
        component: ShowListComponent
      },
      {
        path: "", redirectTo: "add", pathMatch: "full"
      },
      {
        path: "**", redirectTo: "add", pathMatch: "full"
      }
    ],{useHash:true},)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

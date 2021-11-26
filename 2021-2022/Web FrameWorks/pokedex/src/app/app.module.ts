import { Component, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { TextComponent } from './text/text.component';
import { PhotoComponent } from './photo/photo.component';
import { HomeComponent } from './home/home.component';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    TextComponent,
    PhotoComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot([
      {
        path : "home",
        component : HomeComponent
      }
    ])
    



  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

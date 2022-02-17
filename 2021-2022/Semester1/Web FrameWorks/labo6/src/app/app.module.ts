import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { PersoongegevensComponent } from './persoongegevens/persoongegevens.component';
import { WelcomescreenComponent } from './welcomescreen/welcomescreen.component';

@NgModule({
  declarations: [
    AppComponent,
    PersoongegevensComponent,
    WelcomescreenComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

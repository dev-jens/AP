import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { CalculatorComponent } from './calculator/calculator.component';
import { WelcomeComponentComponent } from './welcome-component/welcome-component.component';
import { WelcomeSelectComponentComponent } from './welcome-select-component/welcome-select-component.component';
import { DeLijnComponent } from './de-lijn/de-lijn.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    CalculatorComponent,
    WelcomeComponentComponent,
    WelcomeSelectComponentComponent,
    DeLijnComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

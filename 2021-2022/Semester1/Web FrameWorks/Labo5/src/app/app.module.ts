import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { WelcomeComponentComponent } from './welcome-component/welcome-component.component';
import { CalculatorComponent } from './calculator/calculator.component';
import { TodoLijstComponent } from './todo-lijst/todo-lijst.component';

@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponentComponent,
    CalculatorComponent,
    TodoLijstComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

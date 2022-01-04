import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { WelcomeComponentComponent } from './welcome-component/welcome-component.component';
import { CounterComponent } from './counter/counter.component';
import { RedboxComponent } from './redbox/redbox.component';
import { TodoLijstComponent } from './todo-lijst/todo-lijst.component';
import { MoviePlayerComponent } from './movie-player/movie-player.component';
import { CalculatorComponent } from './calculator/calculator.component';

@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponentComponent,
    CounterComponent,
    RedboxComponent,
    TodoLijstComponent,
    MoviePlayerComponent,
    CalculatorComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

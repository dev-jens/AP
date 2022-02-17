import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { WelcomeComponentComponent } from './welcome-component/welcome-component.component';
import { CounterComponent } from './counter/counter.component';
import { RedboxComponent } from './redbox/redbox.component';
import { TodoLijstComponent } from './todo-lijst/todo-lijst.component';
import { MoviePlayerComponent } from './movie-player/movie-player.component';
import { CalculatorComponent } from './calculator/calculator.component';
import {NavbarComponent} from './navbar/navbar.component';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponentComponent,
    CounterComponent,
    RedboxComponent,
    TodoLijstComponent,
    MoviePlayerComponent,
    CalculatorComponent,
    NavbarComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot([
      {
        path: 'Calculator',
        component: CalculatorComponent
      },
      { 
        path: 'redbox',
        component: RedboxComponent
      },
      {
        path: 'welkom',
        component: WelcomeComponentComponent
      },
      {
        path: 'ToDo',
        component: TodoLijstComponent

      },
      {
        path:"",
        redirectTo: "welkom",
        pathMatch: "full"
      
      },
      {
        path:"**",
        redirectTo: "welkom",
      
      }
    ],
    {
      useHash: true
    })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

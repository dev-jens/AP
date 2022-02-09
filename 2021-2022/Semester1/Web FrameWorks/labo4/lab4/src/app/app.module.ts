import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { CurrentTimeComponent } from './current-time/current-time.component';
import { CounterComponent } from './counter/counter.component';
import { RandintComponent } from './randint/randint.component';
import { StartedAgoComponent } from './started-ago/started-ago.component';
import { RandomScoreComponent } from './random-score/random-score.component';
import { WelkomComponentComponent } from './welkom-component/welkom-component.component';
import { HetWeerComponent } from './het-weer/het-weer.component';

@NgModule({
  declarations: [
    AppComponent,
    CurrentTimeComponent,
    CounterComponent,
    RandintComponent,
    StartedAgoComponent,
    RandomScoreComponent,
    WelkomComponentComponent,
    HetWeerComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

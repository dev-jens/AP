import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { TimeComponent } from './time/time.component';
import { TellerComponent } from './teller/teller.component';
import { RamdomGetalComponent } from './ramdom-getal/ramdom-getal.component';
import { TekstComponent } from './tekst/tekst.component';

@NgModule({
  declarations: [
    AppComponent,
    TimeComponent,
    TellerComponent,
    RamdomGetalComponent,
    TekstComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

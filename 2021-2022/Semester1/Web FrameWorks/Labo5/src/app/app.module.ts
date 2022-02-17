import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { WillekeurigGetalComponent } from './willekeurig-getal/willekeurig-getal.component';
import { WelkomstcomponentComponent } from './welkomstcomponent/welkomstcomponent.component';
import { WeerComponent } from './weer/weer.component';
import { PersoonsinformatieComponent } from './persoonsinformatie/persoonsinformatie.component';
import { AutomerkenComponent } from './automerken/automerken.component';

@NgModule({
  declarations: [
    AppComponent,
    WillekeurigGetalComponent,
    WelkomstcomponentComponent,
    WeerComponent,
    PersoonsinformatieComponent,
    AutomerkenComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

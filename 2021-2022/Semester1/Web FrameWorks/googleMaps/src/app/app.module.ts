import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AgmCoreModule } from '@agm/core';


import { AppComponent } from './app.component';
import { LocationsComponent } from './locations/locations.component';
import { LocationComponent } from './location/location.component';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    AppComponent,LocationsComponent,LocationComponent
  
  ],
  imports: [
    BrowserModule,
    AgmCoreModule.forRoot({
      apiKey: 'AIzaSyBDL9l0nuJ3LE_Y3BGrAA45ncFfcbqhqrA'}),
    RouterModule.forRoot([
      {
        path: "locations", component: LocationsComponent
      },
      {
        path: "maps/:location", component: LocationComponent
      },
      {
        path: "**", component: LocationsComponent
      }
    ],
    {useHash:true}
    )
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

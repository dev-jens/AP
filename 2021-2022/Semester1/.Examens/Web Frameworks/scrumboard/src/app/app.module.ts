import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { BoardComponent } from './board/board.component';
import { CreateStoryComponent } from './create-story/create-story.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    CreateStoryComponent,
    BoardComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      {path:"board",component: BoardComponent},
      {path:"create",component: CreateStoryComponent},
      {path: "", redirectTo: "board", pathMatch: "full"},
      {path:"**",redirectTo:"create",pathMatch:"full"}
     
    ],
    {useHash:true})
    ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

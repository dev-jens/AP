import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { BoardComponent } from './board/board.component';
import { CreateStoryComponent } from './create-story/create-story.component';

@NgModule({
  declarations: [
    AppComponent,
    CreateStoryComponent,
    BoardComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot([
      {path:"create",component:CreateStoryComponent
    },
    {path:"overview",component:BoardComponent
  }
    ])
    ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

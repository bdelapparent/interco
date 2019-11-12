import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TodoComponent } from './todo/todo.component';
import { ParentComponent } from './parent/parent.component';
import { ChildrenComponent } from './children/children.component';
import { Parent1Component } from './parent1/parent1.component';
import { Children1Component } from './children1/children1.component';

@NgModule({
  declarations: [
    AppComponent,
    TodoComponent,
    ParentComponent,
    ChildrenComponent,
    Parent1Component,
    Children1Component
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

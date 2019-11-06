import { Component } from '@angular/core';
import { TodoModel } from './todo.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'projet-component';
  newTodoText: string;
  todoList: TodoModel[] = [];

  addTodo() {
    if(this.newTodoText) {
      this.todoList.push({
        text: this.newTodoText, 
        isChecked: false
      });
      this.newTodoText = "";
    }else{
      alert('Aucun texte saisi')
    }
  }
}

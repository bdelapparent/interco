import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent implements OnInit {

  listName = 'Ma Todo List du composant';
  todos: string[] = [];
  newTodo: string = '';

  createTodo(){
    if(this.newTodo){
      console.log(this.newTodo);
      this.todos.push(this.newTodo);
      this.newTodo = '';
    } 
  }

  constructor() { }

  ngOnInit() {
  }

}

import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent implements OnInit {

  name: string = "Parent";
  email: string = "parent@angular.com";

  get data(){
    return { name: this.name, email: this.email };
  }

  constructor() { }

  ngOnInit() {
  }

}

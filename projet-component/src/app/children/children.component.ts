import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-children',
  templateUrl: './children.component.html',
  styleUrls: ['./children.component.css']
})
export class ChildrenComponent implements OnInit {

  @Input()
  name: string;

  @Input('email')
  mail: string;

  get data() {
    return { name: this.name, email: this.mail};
  }

  constructor() { }

  ngOnInit() {
  }

}

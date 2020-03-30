import { Component, OnInit, Output, EventEmitter } from '@angular/core';




@Component({
  selector: 'app-home-menu',
  templateUrl: './home-menu.component.html',
  styleUrls: ['./home-menu.component.css']
})
export class HomeMenuComponent implements OnInit {

  @Output() LoginAccion= new EventEmitter();


  isExpanded = false;

  constructor() { }

  ngOnInit() {
  }


  send_LoginAccion(idAccion:number) {
    this.LoginAccion.emit(idAccion);
  }


 






}

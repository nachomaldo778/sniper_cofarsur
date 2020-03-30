import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { MatTableDataSource } from '@angular/material';
import { Input } from '@angular/core';

import { NominaService } from 'src/app/services/rrhh/nomina/nomina.service';
import { Nomina } from 'src/app/models/rrhh/nomina.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})


export class HomeComponent implements OnInit {

  idComponente: number;
  txtParam: any;
  idLoginAccion: number;
  @Output() LoginAccionEmit = new EventEmitter();

  constructor(private nominaService: NominaService) { }
  ngOnInit() {

  }

  Recibe_LoginAccion(idAccion:number) {
    if (idAccion == 1) {
      document.getElementById("contenedor").style.opacity = "0.5";
      document.getElementById("contenedor").style.backgroundColor = "black";
      document.getElementById("contenedor").style.pointerEvents = "none";
    }
    else {
      document.getElementById("contenedor").style.opacity = "1";
      document.getElementById("contenedor").style.backgroundColor = "";
    document.getElementById("contenedor").style.pointerEvents = "";
    }
    this.idLoginAccion = idAccion;
  }

  testmysql() {
    this.nominaService.getnomina(4).subscribe((result: Nomina[]) => {
   
      console.log(result);

    });
  }

}

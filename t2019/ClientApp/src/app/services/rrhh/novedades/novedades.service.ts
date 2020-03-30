
import { Injectable, OnInit } from '@angular/core';
import { NovedadesEndPoint } from 'src/app/services/rrhh/novedades/novedades-endpoint';

@Injectable()
export class NovedadesService implements OnInit {

  constructor(private novedadesEndPoint: NovedadesEndPoint) {
  }

  ngOnInit() {

  }


  getnovedades(param?: any) {
    var result = this.novedadesEndPoint.getnovedades(param);
    return result;
  }

}

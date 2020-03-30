import { Injectable, OnInit } from '@angular/core';
import {LoginEndPoint } from './login-endpoint';

@Injectable()
export class LoginService implements OnInit {

  constructor(private loginEndPoint: LoginEndPoint) {
  }

  ngOnInit() {

  }

  ValidarUsuario(CUIT?: any, Usuario?: any, Contraseña?: any) {
    return this.loginEndPoint.ValidarUsuario(CUIT, Usuario, Contraseña);
  }

}

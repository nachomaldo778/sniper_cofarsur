import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { LoginService } from 'src/app/services/login/login.service';
import { MatTableDataSource, MatSnackBar, MatSidenav } from '@angular/material';
import { FormControl, Validators, FormGroup} from '@angular/forms';
import { Usuario } from 'src/app/models/general/usuario.model';
import { Validacion } from 'src/app/models/general/validacion.model';
import { Router } from '@angular/router';
import { MatDialog } from '@angular/material'

import { DomSanitizer, SafeResourceUrl } from '@angular/platform-browser';

@Component({
  selector: 'app-login-home',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {


  Usuario = new FormControl('');
  Pass = new FormControl('');


  username: string;
  password: string;

  valid: boolean;

  userlog: Usuario;
  mostrar: boolean = false;
  
  @Input() public set ReciveLoginId(IdAccion: number) {
    console.log(IdAccion);
    this.Recibe_LoginAccion(IdAccion);
  }

  @Output() LoginAccion = new EventEmitter();

  constructor(private _sanitizer: DomSanitizer,private loginService: LoginService, private _snackBar: MatSnackBar, private router: Router) {

  }


  ngOnInit() {

  }


  login(): void {
    if (this.username == 'admin' && this.password == 'admin') {
      this.router.navigate(["home"]);
    } else {
      alert("Invalid credentials");
    }
  }


  getVideoIframe(url) {
    var video, results;

    if (url === null) {
      return '';
    }
    results = url.match('FBqf8uTZQ3Q');
    video = (results === null) ? url : results[1];

    return this._sanitizer.bypassSecurityTrustResourceUrl(url);
  }


  registrar() {
    console.log(this.userlog)
    this.validarInputs();
    if (this.mostrar===true) {
      this.openSnackBar('snack-success', 'Bienvenido!', 4000);
      this.router.navigate(['/home']);
      
    }
  }

  validarInputs(){
    let mensaje = '';
    this.mostrar = false;

    this.loginService.ValidarUsuario(0, this.Usuario.value, this.Pass.value).subscribe((result: Validacion) => {
      console.log(result);
      if (result.p_ID === 1) {
        this.mostrar = true;

      }

    });


    //return this.mostrar;

  }

  openSnackBar(tema: string, mensaje: string, tiempo: number) {
    this._snackBar.open(mensaje, 'Ok', {
      duration: tiempo,
      panelClass: [tema]
    });
  }





  Recibe_LoginAccion(idAccion: number) {
    if (idAccion == 1) {
      document.getElementById("mySidenav").style.width = "250px";
    }
    else {
      document.getElementById("mySidenav").style.width = "0";
    }
  }

  closeNav(){
    document.getElementById("mySidenav").style.width = "0";
    this.send_LoginAccion(0);
  }


  send_LoginAccion(idAccion: number) {
    this.LoginAccion.emit(idAccion);
  }



  














}


    //if (!this.CUIT.value) {
    //  mostrar = false;
    //  this.CUIT.setValidators([Validators.required]);
    //  mensaje = 'Debe ingresar un nombre de usuario';
    //  this.openSnackBar('snack-danger', mensaje, 4000);
    //}

    //if (!this.Usuario.value) {
    //  mostrar = false;
    //  this.Usuario.setValidators([Validators.required]);
    //  mensaje = 'Debe ingresar un nombre de usuario';
    //  this.openSnackBar('snack-danger', mensaje, 4000);
    //}
    //if (!this.Pass.value) {
    //  mostrar = false;
    //  this.Pass.setValidators([Validators.required]);
    //  mensaje = 'Debe ingresar una contraseña valida';
    //  this.openSnackBar('snack-danger', mensaje, 4000);
    //}




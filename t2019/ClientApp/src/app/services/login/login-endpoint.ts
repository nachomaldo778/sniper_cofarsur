import { HttpClient, HttpHeaders, HttpErrorResponse, HttpParams } from '@angular/common/http';
import { catchError } from 'rxjs/operators';
import { throwError } from 'rxjs';
import { Injectable } from '@angular/core';

@Injectable()
export class LoginEndPoint {

  /* Variables para llamar a API */
  private readonly _url: string = '/api/Login';

  constructor(private http: HttpClient) { }

  protected getRequestHeaders(params?: any): HttpHeaders {
    let headers = new HttpHeaders({
      'Authorization': 'Bearer ' + '',
      'Content-Type': 'application/json',
      'Accept': `application/json, text/plain, */*`,
      'App-Version': '1.0'
    });

    return headers;
  }

  handleError(error: HttpErrorResponse) {
    return throwError(error);
  }

  ValidarUsuario(CUIT?: any, Usuario?: any, Contraseña?: any) {
    let endpointUrl = this._url + '/ValidarUsuario';

    const params = new HttpParams()
      .set('CUIT', (CUIT) ? CUIT : 0)
      .set('Usuario', (Usuario) ? Usuario : 0)
      .set('Contraseña', (Contraseña) ? Contraseña : 0);

    return this.http.get(endpointUrl, { headers: this.getRequestHeaders(), params: params }).pipe(
      catchError(error => {
        return this.handleError(error);
      }));
  }
}

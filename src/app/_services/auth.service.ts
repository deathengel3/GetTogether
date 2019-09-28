import { Injectable } from '@angular/core';
import { Usuario } from '../_models';
import { BehaviorSubject, Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private API_URL = `http://localhost:53702/api`;
  public currentUserSubject: BehaviorSubject<Usuario>;
  public currentUser: Observable<Usuario>;
  public datosLogin: string = '';

  constructor(private http: HttpClient) { 
    this.currentUserSubject = new BehaviorSubject<Usuario>(JSON.parse(localStorage.getItem('currentAccess')));
    this.currentUser = this.currentUserSubject.asObservable();
  }

  // Regresa objeto de usuario cuando está logeado
  public get currentUserValue(): Usuario {
    return this.currentUserSubject.value;
  }

  /*public isAuthenticated(): boolean {
    let authenticated = false;
    
    if(this.currentUserValue)
      authenticated = true;

    return authenticated;
  }*/

  login(usuario: string, password: string):any {
    //Encriptar datos
    this.datosLogin = `${usuario}|${password}`;
    let user: Usuario;
    return this.http.get<any>(`${this.API_URL}/auth/login`, {})
      .pipe(
          map(
            data => {
              if (data && data.token) {
                localStorage.setItem('currentAccess', JSON.stringify(data));
                this.currentUserSubject.next(data);
              }
            }
          )
      );
  }
  
  logout() {
    localStorage.removeItem('currentAccess');
    this.currentUserSubject.next(null);
  }

}

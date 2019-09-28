import { Injectable } from '@angular/core';
import { HttpRequest, HttpHandler, HttpEvent, HttpInterceptor } from '@angular/common/http';
import { Observable } from 'rxjs';

import { AuthService } from '../_services';

@Injectable()
export class JwtInterceptor implements HttpInterceptor {
    constructor(private authService: AuthService) {}

    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        let currentUser = this.authService.currentUserValue;
        let tmpUser = null;
        let urlPeticion = request.url.toString();
        debugger;
        const isLoggedIn = currentUser && currentUser.token;

        if(urlPeticion.includes("login") && !isLoggedIn){
            tmpUser = this.authService.datosLogin.toString();
            request = request.clone({
                setHeaders: { 
                    ContentType: "application/x-www-form-urlencoded",
                    Authorization: "Basic " + btoa(tmpUser)
                }
            });
        } else if(isLoggedIn){
            request = request.clone({
                setHeaders: { 
                    Authorization: `Bearer ${currentUser.token}`
                }
            });
        }
        return next.handle(request);
    }
}
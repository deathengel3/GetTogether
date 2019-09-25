import { AuthService } from './../_services/auth.service';
import { Injectable } from '@angular/core';
import { CanActivate, Router, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';


@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private authService: AuthService, private router: Router){

  }
  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
    debugger;
    const currentUser = this.authService.currentUserValue;
    const isAuthenticated = currentUser && currentUser.token;

    if(!isAuthenticated){
      this.router.navigate(['login']);
      return false;
    }

    return true;
  }
}

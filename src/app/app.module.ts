import { BrowserModule } from '@angular/platform-browser';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';

// MODULES
import { AppRoutingModule } from './app-routing.module';
import { GridModule } from '@progress/kendo-angular-grid';
import { MaterialModule } from './material-module';

//COMPONENTS
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule, PreloadAllModules } from '@angular/router';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { HttpClientModule } from '@angular/common/http';

// SERVICES
import { JwtInterceptor, ErrorInterceptor } from './_helpers';
import { AuthGuard } from './_guards/auth.guard';
import { LoginGuard } from './_guards/login.guard';
import { AuthService } from './_services';

// Routes
import { routes } from './app.routing';
import { IndexModule } from './index/index.module';
import { NoPageFoundModule } from './no-page-found/no-page-found.module';
//import { AdminHomeModule } from './admin-home/admin-home.module';
import { UserHomeModule } from './user-home/user-home.module';


@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    GridModule,
    MaterialModule,
    IndexModule,
    NoPageFoundModule,
    UserHomeModule,
    HttpClientModule,
    RouterModule.forRoot(routes, { useHash: true })
  ],
  providers: [
    AuthGuard, LoginGuard, AuthService,
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
  ],
  bootstrap: [ AppComponent ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class AppModule { }

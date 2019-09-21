import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

// MODULES
import { SharedComponentsModule } from '../../shared-components/shared-components.module';
import { RouterModule } from '@angular/router';

// COMPONENTS 
import { LoginComponent } from './login.component';
import { LoginRoutes } from './login.routes';



@NgModule({
  declarations: [LoginComponent],
  imports: [
    RouterModule.forChild(LoginRoutes),
    CommonModule,
    SharedComponentsModule
  ],
  exports: [LoginComponent]
})
export class LoginModule { }

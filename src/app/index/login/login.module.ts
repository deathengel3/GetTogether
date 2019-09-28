import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

// MODULES
import { SharedComponentsModule } from '../../shared-components/shared-components.module';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';

// COMPONENTS 
import { LoginComponent } from './login.component';
import { LoginRoutes } from './login.routes';
import { MaterialModule } from 'src/app/material-module';



@NgModule({
  declarations: [LoginComponent],
  imports: [
    RouterModule.forChild(LoginRoutes),
    CommonModule,
    SharedComponentsModule,
    MaterialModule,
    ReactiveFormsModule,
    FormsModule
  ],
  exports: [LoginComponent]
})
export class LoginModule { }

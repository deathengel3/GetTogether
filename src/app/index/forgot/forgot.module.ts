import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ForgotComponent } from './forgot.component';
import { RouterModule } from '@angular/router';
import { ForgotRoutes } from './forgot.routes';

@NgModule({
  declarations: [ForgotComponent],
  exports: [ForgotComponent],
  imports: [
    RouterModule.forChild(ForgotRoutes),
    CommonModule
  ]
})
export class ForgotModule { }

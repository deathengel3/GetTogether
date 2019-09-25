import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DashboardComponent } from './dashboard.component';
import { RouterModule } from '@angular/router';
import { DashboardRoutes } from './dashboard.routes';
import { SharedComponentsModule } from '../../shared-components/shared-components.module';



@NgModule({
  declarations: [DashboardComponent],
  exports: [DashboardComponent],
  imports: [
    CommonModule,
    SharedComponentsModule,
    RouterModule.forChild(DashboardRoutes)
  ]
})
export class DashboardModule { }

import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserHomeComponent } from './user-home.component';
import { RouterModule } from '@angular/router';
import { SharedComponentsModule } from '../shared-components/shared-components.module';



@NgModule({
  declarations: [UserHomeComponent],
  imports: [CommonModule, RouterModule, SharedComponentsModule],
  exports: [UserHomeComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class UserHomeModule { }

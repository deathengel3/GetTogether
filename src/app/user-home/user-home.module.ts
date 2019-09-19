import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserHomeComponent } from './user-home.component';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [UserHomeComponent],
  imports: [CommonModule, RouterModule],
  exports: [UserHomeComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class UserHomeModule { }

import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminHomeComponent } from './admin-home.component';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { SharedComponentsModule } from '../shared-components/shared-components.module';

@NgModule({
  declarations: [AdminHomeComponent],
  imports: [CommonModule, RouterModule, FormsModule, SharedComponentsModule],
  exports: [AdminHomeComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class AdminHomeModule { }

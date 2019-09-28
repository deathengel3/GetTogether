import { CommonModule } from '@angular/common';
import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SharedComponentsModule } from '../shared-components/shared-components.module';
import { IndexComponent } from './index.component';

@NgModule({
  declarations: [IndexComponent],
  imports: [CommonModule, RouterModule, FormsModule, SharedComponentsModule, ReactiveFormsModule],
  exports: [IndexComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class IndexModule { }


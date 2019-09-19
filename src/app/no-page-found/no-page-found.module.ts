import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { SharedComponentsModule } from '../shared-components/shared-components.module';
import { NoPageFoundComponent } from './no-page-found.component';
import { CommonModule } from '@angular/common';

@NgModule({
  declarations: [NoPageFoundComponent],
  imports: [CommonModule, RouterModule, FormsModule, SharedComponentsModule],
  exports: [NoPageFoundComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class NoPageFoundModule { }

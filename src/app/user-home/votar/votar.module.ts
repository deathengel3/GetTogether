import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { VotarRoutes } from './votar.routes';
import { VotarComponent } from './votar.component';
import {MaterialModule} from '../../material-module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ModalDialogComponent } from '../../shared-components/modal-dialog/modal-dialog.component';


@NgModule({
  declarations: [VotarComponent, ModalDialogComponent],
  imports: [
    CommonModule,
    RouterModule.forChild(VotarRoutes),
    MaterialModule,
    FormsModule,
    ReactiveFormsModule
  ],
  exports: [VotarComponent],
  entryComponents: [ModalDialogComponent]
})
export class VotarModule { }

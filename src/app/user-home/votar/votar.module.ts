import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { VotarRoutes } from './votar.routes';
import { VotarComponent } from './votar.component';


@NgModule({
  declarations: [VotarComponent],
  imports: [
    CommonModule,
    RouterModule.forChild(VotarRoutes)
  ],
  exports: [VotarComponent]
})
export class VotarModule { }

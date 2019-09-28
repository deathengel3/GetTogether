import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { HeaderComponent } from './header/header.component';
import {MaterialModule} from '../material-module';
import { MenuListComponent } from './header/menu-list/menu-list.component';
import {RouterModule} from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [HeaderComponent, MenuListComponent],
  imports: [CommonModule, MaterialModule, RouterModule, FormsModule, ReactiveFormsModule],
  exports: [HeaderComponent]
})
export class SharedComponentsModule { }


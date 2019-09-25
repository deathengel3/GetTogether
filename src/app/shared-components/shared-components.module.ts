import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { HeaderComponent } from './header/header.component';
import {MaterialModule} from '../material-module';
import { MenuListComponent } from './header/menu-list/menu-list.component';

@NgModule({
  declarations: [HeaderComponent, MenuListComponent],
  imports: [CommonModule, MaterialModule],
  exports: [HeaderComponent]
})
export class SharedComponentsModule { }


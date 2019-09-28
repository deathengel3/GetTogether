import { Component, OnInit, Input } from '@angular/core';
import { ITEMS_MENU } from './menu-routes-config';

@Component({
  selector: 'app-menu-list',
  templateUrl: './menu-list.component.html',
  styleUrls: ['./menu-list.component.scss']
})
export class MenuListComponent implements OnInit {
  @Input() optionMenuList2 = '';
  private itemsMenu: any[];
  constructor() {
    this.itemsMenu = ITEMS_MENU;
  }

  ngOnInit() {
  }

}

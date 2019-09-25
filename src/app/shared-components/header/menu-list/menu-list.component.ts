import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-menu-list',
  templateUrl: './menu-list.component.html',
  styleUrls: ['./menu-list.component.scss']
})
export class MenuListComponent implements OnInit {
  @Input('optionMenuList2') optionMenuList2: string = '';
  private login_menu = true;
  
  constructor() { }

  ngOnInit() {
  }

}

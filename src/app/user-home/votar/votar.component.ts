import {Component, OnInit, OnChanges, Inject} from '@angular/core';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { CARD_ITEMS } from './cards-items-config';
import {ModalDialogComponent} from '../../shared-components/modal-dialog/modal-dialog.component';

@Component({
  selector: 'app-votar',
  templateUrl: './votar.component.html',
  styleUrls: ['./votar.component.scss']
})
export class VotarComponent implements OnInit {
  private option = '';
  private cardsItems: any[] = CARD_ITEMS;
  constructor(public dialog: MatDialog) {}
  ngOnInit() {
  }

  openDialog(optionComida: any, lugarOption: any): void {
    console.log(optionComida);
    console.log(lugarOption);
    const dialogRef = this.dialog.open(ModalDialogComponent, {
      width: '250px',
      data: {optionComida}
    });
    dialogRef.afterClosed().subscribe(result => {
      console.log("modal cerrado");
    });
  }
}

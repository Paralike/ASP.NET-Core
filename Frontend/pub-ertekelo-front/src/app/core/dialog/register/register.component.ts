import {Component, inject, OnInit} from '@angular/core';
import {MatDialogRef,MAT_DIALOG_DATA} from "@angular/material/dialog";

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  user={
    felhasznalonev:'',
    jelszo:'',
    email:''
  };

  constructor(public dialogRef: MatDialogRef<RegisterComponent>, @inject(MAT_DIALOG_DATA) public data:any) { }

  ngOnInit(): void {
  }

  onNoClick(): void{
    this.dialogRef.close();
  }

}

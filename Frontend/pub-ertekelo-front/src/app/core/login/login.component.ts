import { Component, OnInit } from '@angular/core';
import {RegisterComponent} from "../dialog/register/register.component";
import {MatDialog} from "@angular/material/dialog";
import {Router} from "@angular/router";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  constructor(public dialog: MatDialog, private router: Router) { }

  ngOnInit(): void {
  }

  register(){
    const dialogRef = this.dialog.open(RegisterComponent,{
      width:'450px'
    });

    dialogRef.afterClosed().subscribe(result =>{

    });
  }

}

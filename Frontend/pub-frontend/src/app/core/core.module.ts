import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login/login.component';
import { LayoutComponent } from './layout/layout.component';
import {RouterModule} from "@angular/router";
import {SharedModule} from "../shared/shared.module";
import {MatInputModule} from "@angular/material/input";



@NgModule({
  declarations: [LoginComponent, LayoutComponent],
  imports: [
    CommonModule,
    RouterModule,
    SharedModule,
    MatInputModule
  ]
})
export class CoreModule { }

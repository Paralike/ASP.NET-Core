import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {RouterModule} from "@angular/router";
import {SharedModule} from "../shared/shared.module";
import {LoginComponent} from "./login/login.component";
import {LayoutComponent} from "./layout/layout.component";



@NgModule({
  declarations: [LoginComponent,LayoutComponent],
  imports: [
    CommonModule,
    RouterModule,
    SharedModule
  ]
})
export class CoreModule { }

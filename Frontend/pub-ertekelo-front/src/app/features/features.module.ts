import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { VendeglatokComponent } from './vendeglatok/vendeglatok.component';
import {FeaturesRoutingModule} from "./features-routing.module";



@NgModule({
  declarations: [VendeglatokComponent],
  imports: [
    CommonModule,
    FeaturesRoutingModule
  ]
})
export class FeaturesModule { }

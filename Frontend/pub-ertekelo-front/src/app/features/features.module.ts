import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { VendeglatokComponent } from './vendeglatok/vendeglatok.component';
import {FeaturesRoutingModule} from "./features-routing.module";
import {SharedModule} from "../shared/shared.module";



@NgModule({
  declarations: [VendeglatokComponent],
  imports: [
    CommonModule,
    FeaturesRoutingModule,
    SharedModule
  ]
})
export class FeaturesModule { }

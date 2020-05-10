import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {VendeglatokComponent} from "./vendeglatok/vendeglatok.component";


const routes: Routes = [
  {path:'',component:VendeglatokComponent}
];

@NgModule({
  imports:[RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FeaturesRoutingModule {}

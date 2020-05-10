import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {LoginComponent} from "./core/login/login.component";
import {LayoutComponent} from "./core/layout/layout.component";
import {AuthGuard} from "./core/auth.guard";
import {FeaturesModule} from './features/features.module';


const routes: Routes = [
  {path: 'login',component:LoginComponent},
  {path:'',component: LayoutComponent, canActivate: [AuthGuard], children:[
    {path:'',pathMatch: 'full',redirectTo:'vendeglatok'},
    {path:'vendeglatok',loadChildren:()=>FeaturesModule}
    ]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

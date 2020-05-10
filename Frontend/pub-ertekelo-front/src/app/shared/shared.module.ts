import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatCardModule} from '@angular/material/card';
import {FormsModule} from "@angular/forms";
import {MatInputModule} from '@angular/material/input';
import {MatButtonModule} from '@angular/material/button';


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    MatCardModule,
    FormsModule,
    MatInputModule,
    MatButtonModule
  ],
  exports: [
    MatCardModule,
    FormsModule,
    MatInputModule,
    MatButtonModule
  ]
})
export class SharedModule { }

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatCardModule} from '@angular/material/card';
import {FormsModule} from '@angular/forms';
import {MatInputModule} from '@angular/material/input';
import {MatButtonModule} from '@angular/material/button';
import {MatDialogModule} from '@angular/material/dialog';


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    MatCardModule,
    FormsModule,
    MatInputModule,
    MatButtonModule,
    MatDialogModule
  ],
  exports: [
    MatCardModule,
    FormsModule,
    MatInputModule,
    MatButtonModule,
    MatDialogModule
  ]
})
export class SharedModule { }

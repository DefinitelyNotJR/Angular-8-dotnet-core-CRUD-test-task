import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeeAddComponent } from './employee-add/employee-add.component';
import { EmployeeGetComponent } from './employee-get/employee-get.component';
import { PositionAddComponent } from './position-add/position-add.component';
import { HttpClientModule } from '@angular/common/http';
import { PositionsService } from './positions.service';
import { MatDialogModule } from '@angular/material/dialog';
import { EmployeesService } from './employees.service';


@NgModule({
  declarations: [
    AppComponent,
    EmployeeAddComponent,
    EmployeeGetComponent,
    PositionAddComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    MatDialogModule
  ],
  providers: [
    PositionsService,
    EmployeesService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

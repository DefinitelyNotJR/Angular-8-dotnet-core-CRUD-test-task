import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EmployeeAddComponent } from './employee-add/employee-add.component';
import { EmployeeGetComponent } from './employee-get/employee-get.component';
import { PositionAddComponent } from './position-add/position-add.component';

const routes: Routes = [
  {
    path: 'employee/add',
    component: EmployeeAddComponent
  },
  {
    path: 'employees',
    component: EmployeeGetComponent
  },
  {
    path: 'position/add',
    component: PositionAddComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

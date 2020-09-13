import { Component, OnInit } from '@angular/core';
import Employee from '../employee-add/Employee';
import { EmployeesService } from '../employees.service';

@Component({
  selector: 'app-employee-get',
  templateUrl: './employee-get.component.html',
  styleUrls: ['./employee-get.component.css']
})
export class EmployeeGetComponent implements OnInit {

  

  employees: Employee[] = [];
  constructor(private es: EmployeesService) { }

  ngOnInit() {
    this.es.getAllEmployees().subscribe(res => this.employees = res);
  }

}

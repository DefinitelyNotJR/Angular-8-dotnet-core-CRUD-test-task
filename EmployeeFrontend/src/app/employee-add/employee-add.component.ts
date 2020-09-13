import { Component, OnInit } from '@angular/core';
import { EmployeesService } from '../employees.service';
import Position from '../position-add/Position';
import { PositionsService } from '../positions.service';

@Component({
  selector: 'app-employee-add',
  templateUrl: './employee-add.component.html',
  styleUrls: ['./employee-add.component.css']
})
export class EmployeeAddComponent implements OnInit {


  jobs: Position[] = [];

  constructor(private ps: PositionsService, private es: EmployeesService) { }

  ngOnInit() {
    this.ps.getPositions().subscribe(res => this.jobs = res);
    

  }
  addEmployee(EmSurname, EmName, Position, Salary, DateStartedWorking, DateStoppedWorking ){
    this.es.addEmployee(EmName, EmSurname, Position, Salary, DateStartedWorking, DateStoppedWorking);
  }
}

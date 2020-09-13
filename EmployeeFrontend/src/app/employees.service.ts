import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import Employee from './employee-add/Employee';


@Injectable({
  providedIn: 'root'
})
export class EmployeesService {


  uri = 'https://localhost:5001/employee';
  constructor(private http: HttpClient) { }

  addEmployee(EmSurname, EmName, Position, Salary, DateStartedWorking, DateStoppedWorking){
    const Name = EmSurname + ' ' + EmName;
    const obj = {
      Name,
      Position,
      Salary,
      DateStartedWorking,
      DateStoppedWorking
    };
    console.log(obj);
    this.http.post(`${this.uri}/add`, obj).subscribe(res => console.log('Done'));
  }

  getAllEmployees(): Observable<Employee[]>{
    return this.http.get<Employee[]>(this.uri);
  }
}

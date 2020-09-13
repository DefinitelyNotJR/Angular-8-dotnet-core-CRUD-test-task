import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import Position from './position-add/Position';

@Injectable({
  providedIn: 'root'
})
export class PositionsService {

  uri = 'https://localhost:5001/position';

  constructor(private http: HttpClient) { }

  addPosition(Name)  {
    const obj = {
      Name
    };
    console.log(obj);
    this.http.post(`${this.uri}/add`, obj).subscribe(res => console.log('Done'));
  }

  getPositions(): Observable<Position[]>{
    return this.http.get<Position[]>(this.uri);
  }
}

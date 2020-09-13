import { Component, OnInit } from '@angular/core';
import { PositionsService } from '../positions.service';

@Component({
  selector: 'app-position-add',
  templateUrl: './position-add.component.html',
  styleUrls: ['./position-add.component.css']
})
export class PositionAddComponent implements OnInit {

  constructor(private ps: PositionsService) { }

  ngOnInit() {
  }

  addPosition(Name) {
    this.ps.addPosition(Name);
  }

}

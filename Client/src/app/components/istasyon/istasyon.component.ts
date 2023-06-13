import { Component, Input, OnInit } from '@angular/core';
import { Istasyon } from 'src/app/models/Istasyon';

@Component({
  selector: 'app-istasyon',
  templateUrl: './istasyon.component.html',
  styleUrls: ['./istasyon.component.css']
})

export class IstasyonComponent {
  @Input() istasyon!: Istasyon;

  ngOnInit(): void {
    
  }
}
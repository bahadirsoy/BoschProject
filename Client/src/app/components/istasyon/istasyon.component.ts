import { Component, Input, OnInit } from '@angular/core';
import { Istasyon } from 'src/app/models/Istasyon';
import { BoschService } from 'src/app/services/bosch.service';

@Component({
  selector: 'app-istasyon',
  templateUrl: './istasyon.component.html',
  styleUrls: ['./istasyon.component.css']
})

export class IstasyonComponent {
  @Input() istasyon!: Istasyon;

  altParcasAndStokAlani: any = [];

  constructor(private httpService: BoschService) {

  }

  ngOnInit(): void {
    console.log(this.istasyon);
   
    this.httpService.getAltParcasAndStokAlaniByIstasyon(this.istasyon.id).subscribe((altParcasAndStokAlani) => {
      this.altParcasAndStokAlani = altParcasAndStokAlani;
    })
  }
}
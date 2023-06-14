import { Component, Input, OnInit } from '@angular/core';
import { Enjektor } from 'src/app/models/Enjektor';
import { Istasyon } from 'src/app/models/Istasyon';
import { BoschService } from 'src/app/services/bosch.service';

@Component({
  selector: 'app-istasyon',
  templateUrl: './istasyon.component.html',
  styleUrls: ['./istasyon.component.css']
})

export class IstasyonComponent {
  @Input() istasyon!: Istasyon;
  @Input() siparisId!: string;

  altParcasAndStokAlani: any = [];
  enjektor!: Enjektor;

  constructor(private httpService: BoschService) {

  }

  ngOnInit(): void {
    this.httpService.getAltParcasAndStokAlaniByIstasyon(this.istasyon.id).subscribe((altParcasAndStokAlani) => {
      this.altParcasAndStokAlani = altParcasAndStokAlani;
      //console.log(this.altParcasAndStokAlani);
    })

    this.httpService.getEnjektorBySiparis(+this.siparisId).subscribe((enjektor) => {
      this.httpService.getAltParcasByEnjektor(enjektor.id).subscribe((altParcas) => {
        console.log(altParcas);
      })
    })
  }
}
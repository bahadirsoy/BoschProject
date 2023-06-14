import { Component, Input, OnInit } from '@angular/core';
import { AltParca } from 'src/app/models/AltParca';
import { Enjektor } from 'src/app/models/Enjektor';
import { Istasyon } from 'src/app/models/Istasyon';
import { BoschService } from 'src/app/services/bosch.service';
import { faClipboardCheck } from '@fortawesome/free-solid-svg-icons';
import { NgbTooltipModule } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-istasyon',
  templateUrl: './istasyon.component.html',
  styleUrls: ['./istasyon.component.css']
})

export class IstasyonComponent {
  @Input() istasyon!: Istasyon;
  @Input() siparisId!: string;

  altParcasAndStokAlani: any = [];
  altParca!: AltParca;
  isProduced!: boolean;
  faClipboardCheck = faClipboardCheck;

  constructor(private httpService: BoschService) {

  }

  ngOnInit(): void {
    this.httpService.getAltParcasAndStokAlaniByIstasyon(this.istasyon.id).subscribe((altParcasAndStokAlani) => {
      this.altParcasAndStokAlani = altParcasAndStokAlani;
    })

    this.httpService.getEnjektorBySiparis(+this.siparisId).subscribe((enjektor) => {
      this.httpService.getAltParcaByEnjektorAndIstasyon(enjektor.id, this.istasyon.id).subscribe((altParca) => {
        this.altParca = altParca;

        this.httpService.getIsProduced(+this.siparisId, this.altParca.id).subscribe((bool) => {
          this.isProduced = bool;
        })
      })
    })
  }
}
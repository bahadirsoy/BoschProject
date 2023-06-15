import { Component, Input, OnInit } from '@angular/core';
import { AltParca } from 'src/app/models/AltParca';
import { Enjektor } from 'src/app/models/Enjektor';
import { Istasyon } from 'src/app/models/Istasyon';
import { BoschService } from 'src/app/services/bosch.service';
import { faClipboardCheck, faIndustry } from '@fortawesome/free-solid-svg-icons';
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
  neededAltParca!: AltParca;
  isProduced!: boolean;

  //icons
  faClipboardCheck = faClipboardCheck;
  faIndustry = faIndustry;

  //alert
  successAlertDisplay = "none";
  errorAlertDisplay = "none";

  //check if there is enough stok adeti
  stokAdeti! : number;
  neededAdet!: number;

  constructor(private httpService: BoschService) {

  }

  onClick() {
    this.httpService.getStokAlaniByAltParca(this.neededAltParca.id).subscribe((stokAlani) => {
      this.stokAdeti = stokAlani.stokAdeti;

      this.httpService.getSiparis(+this.siparisId).subscribe((siparis) => {
        this.neededAdet = siparis.adet;

        if(this.stokAdeti < this.neededAdet){
          this.errorAlertDisplay = "block";
          return;
        }
    
        this.httpService.createUretim(+this.siparisId, this.neededAltParca.id).subscribe((result) => {
          this.isProduced = true;
        })
    
        this.successAlertDisplay = "block";
      })
    })
  }

  ngOnInit(): void {
    this.httpService.getAltParcasAndStokAlaniByIstasyon(this.istasyon.id).subscribe((altParcasAndStokAlani) => {
      this.altParcasAndStokAlani = altParcasAndStokAlani;
    })

    this.httpService.getEnjektorBySiparis(+this.siparisId).subscribe((enjektor) => {
      this.httpService.getAltParcaByEnjektorAndIstasyon(enjektor.id, this.istasyon.id).subscribe((altParca) => {
        this.neededAltParca = altParca;

        this.httpService.getIsProduced(+this.siparisId, this.neededAltParca.id).subscribe((bool) => {
          this.isProduced = bool;
        })
      })
    })
  }
}
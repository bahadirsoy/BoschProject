import { Component } from '@angular/core';
import { Siparis } from 'src/app/models/Siparis';
import { BoschService } from 'src/app/services/bosch.service';

@Component({
  selector: 'app-create-siparis',
  templateUrl: './create-siparis.component.html',
  styleUrls: ['./create-siparis.component.css']
})
export class CreateSiparisComponent {
  id!: number;
  adet!: number;

  alertDisplay: string = 'none';

  constructor(private httpService: BoschService) {

  }

  onSubmit() {
    const newSiparis: Siparis = {
      Adet: this.adet,
      SiparisDurumu: 0
    }

    this.httpService.createSiparis(newSiparis, this.id).subscribe((siparis) => {
      this.alertDisplay = '';
    })
  }
}

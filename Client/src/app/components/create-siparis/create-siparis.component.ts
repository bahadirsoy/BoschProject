import { Component } from '@angular/core';
import { BoschService } from 'src/app/services/bosch.service';

@Component({
  selector: 'app-create-siparis',
  templateUrl: './create-siparis.component.html',
  styleUrls: ['./create-siparis.component.css']
})
export class CreateSiparisComponent {
  id!: number;
  adet!: number;

  constructor(private httpService: BoschService) {

  }

  onSubmit() {
    const newSiparis = {
      id: this.id,
      adet: this.adet,
      siparisDurumu: 0
    }

    
  }
}

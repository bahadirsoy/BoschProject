import { Component, OnInit } from '@angular/core';
import { AltParcaStok } from 'src/app/models/AltParcaStok';
import { BoschService } from 'src/app/services/bosch.service';

@Component({
  selector: 'app-homepage',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.css']
})
export class HomepageComponent {
  altParcaStoks: AltParcaStok[] = [];
  
  constructor(private httpService: BoschService) {

  }

  ngOnInit(): void {
    this.httpService.getAltParcaStoks().subscribe((altParcaStoks) => {
      this.altParcaStoks = altParcaStoks;
      console.log(this.altParcaStoks);
    });
  }
}

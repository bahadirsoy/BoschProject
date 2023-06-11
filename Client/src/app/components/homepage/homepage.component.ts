import { Component, OnInit } from '@angular/core';
import { BoschService } from 'src/app/services/bosch.service';

@Component({
  selector: 'app-homepage',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.css']
})
export class HomepageComponent {
  altParcaStoks: any = [];
  
  constructor(private httpService: BoschService) {

  }

  ngOnInit(): void {
    this.httpService.getAltParcaStoks().subscribe((altParcaStoks) => {
      this.altParcaStoks = altParcaStoks;
      console.log(this.altParcaStoks);
    });
  }
}

import { Component, OnInit } from '@angular/core';
import { BoschService } from 'src/app/services/bosch.service';

@Component({
  selector: 'app-manufacture',
  templateUrl: './manufacture.component.html',
  styleUrls: ['./manufacture.component.css']
})

export class ManufactureComponent {
  siparisAndEnjektors: any = [];

  constructor(private httpService: BoschService) {

  }

  ngOnInit(): void {
    this.httpService.getSiparisAndEnjektors().subscribe((siparisAndEnjektors) => {
      this.siparisAndEnjektors = siparisAndEnjektors;
      ///console.log(siparisAndEnjektors);
    })
  }
}

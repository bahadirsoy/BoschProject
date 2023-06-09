import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Enjektor } from 'src/app/models/Enjektor';
import { Istasyon } from 'src/app/models/Istasyon';
import { BoschService } from 'src/app/services/bosch.service';

@Component({
  selector: 'app-production',
  templateUrl: './production.component.html',
  styleUrls: ['./production.component.css']
})

export class ProductionComponent {
  id!: string;
  istasyons: Istasyon[] = [];

  constructor(private route: ActivatedRoute, private httpService: BoschService) {

  }

  ngOnInit(): void {
    this.id = this.route.snapshot.paramMap.get('id') as string;
   
    this.httpService.getIstasyons().subscribe((istasyons) => {
      this.istasyons = istasyons;
    })
  }
}
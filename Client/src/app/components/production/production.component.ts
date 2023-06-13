import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BoschService } from 'src/app/services/bosch.service';

@Component({
  selector: 'app-production',
  templateUrl: './production.component.html',
  styleUrls: ['./production.component.css']
})

export class ProductionComponent {
  id!: string;

  constructor(private route: ActivatedRoute, private httpService: BoschService) {

  }

  ngOnInit(): void {
    this.id = this.route.snapshot.paramMap.get('id') as string;
   
    this.httpService.getIstasyons().subscribe((istasyons) => {
      console.log(istasyons);
    })
  }
}
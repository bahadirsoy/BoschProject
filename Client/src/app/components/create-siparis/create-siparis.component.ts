import { Component } from '@angular/core';

@Component({
  selector: 'app-create-siparis',
  templateUrl: './create-siparis.component.html',
  styleUrls: ['./create-siparis.component.css']
})
export class CreateSiparisComponent {
  id!: number;
  adet!: number;

  onSubmit() {
    console.log("submitted");
  }
}

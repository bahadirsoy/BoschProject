import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { AltParcaStok } from '../models/AltParcaStok';
import { Siparis } from '../models/Siparis'
import { Istasyon } from '../models/Istasyon';

@Injectable({
  providedIn: 'root'
})
export class BoschService {
  private apiUrl = 'https://localhost:7232/api/'

  constructor(private http: HttpClient) { }

  getAltParcaStoks(): Observable<AltParcaStok[]> {
    return this.http.get<AltParcaStok[]>(this.apiUrl + "AltParca");
  }

  createSiparis(siparis: Siparis, enjektorId: number) {
    return this.http.post(this.apiUrl + "Siparis?enjektorId=" + enjektorId, siparis, {responseType: 'text'});
  }

  getSiparisAndEnjektors() {
    return this.http.get(this.apiUrl + "Siparis/siparisAndEnjektors");
  }

  getIstasyons(): Observable<Istasyon[]> {
    return this.http.get<Istasyon[]>(this.apiUrl + "Istasyon");
  }
}

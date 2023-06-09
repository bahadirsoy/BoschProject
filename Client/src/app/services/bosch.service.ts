import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { AltParcaStok } from '../models/AltParcaStok';
import { Siparis } from '../models/Siparis'
import { Istasyon } from '../models/Istasyon';
import { Enjektor } from '../models/Enjektor';
import { AltParca } from '../models/AltParca';
import { StokAlani } from '../models/StokAlani';

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

  getAltParcasAndStokAlaniByIstasyon(istasyonId: number) {
    return this.http.get(this.apiUrl + "Istasyon/" + istasyonId + "/AltParcasAndStokAlani");
  }

  getEnjektorBySiparis(siparisId: number): Observable<Enjektor>  {
    return this.http.get<Enjektor>(this.apiUrl + "Siparis/" + siparisId + "/enjektor");
  }

  getAltParcasByEnjektor(enjektorId: number) {
    return this.http.get(this.apiUrl + "Enjektor/" + enjektorId + "/altParca");
  }

  getAltParcasByIstasyon(istasyonId: number) {
    return this.http.get(this.apiUrl + "Istasyon/" + istasyonId + "/altParca");
  }

  getAltParcaByEnjektorAndIstasyon(enjektorId: number, istasyonId: number): Observable<AltParca> {
    return this.http.get<AltParca>(this.apiUrl + "Enjektor/" + enjektorId + "/" + istasyonId + "/altParca");
  }

  getIsProduced(siparisId: number, altParcaId: number): Observable<boolean> {
    return this.http.get<boolean>(this.apiUrl + "Uretim/" + siparisId + "/" + altParcaId + "/isProduced");
  }
  
  createUretim(siparisId: number, altParcaId: number) {
    return this.http.post(this.apiUrl + "Uretim?siparisId=" + siparisId + "&altParcaId=" + altParcaId, {}, {responseType: 'text'});
  }

  getSiparis(siparisId: number): Observable<Siparis> {
    return this.http.get<Siparis>(this.apiUrl + "Siparis/" + siparisId);
  }

  getStokAlaniByAltParca(altParcaId: number): Observable<StokAlani> {
    return this.http.get<StokAlani>(this.apiUrl + "AltParca/" + altParcaId + "/stokAlani");
  }
}

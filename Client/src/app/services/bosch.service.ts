import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { AltParcaStok } from '../models/AltParcaStok';

@Injectable({
  providedIn: 'root'
})
export class BoschService {
  private apiUrl = 'https://localhost:7232/api/'

  constructor(private http: HttpClient) { }

  getAltParcaStoks(): Observable<AltParcaStok[]> {
    return this.http.get<AltParcaStok[]>(this.apiUrl + "AltParca");
  }

  
}

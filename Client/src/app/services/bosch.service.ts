import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class BoschService {
  private apiUrl = 'https://localhost:7232/api/'

  constructor(private http: HttpClient) { }

  getAltParcaStoks(): Observable<any> {
    return this.http.get<any>(this.apiUrl + "AltParca");
  }
}

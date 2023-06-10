import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DepartmanService {

  constructor(private http: HttpClient) { }

  getDepartmans(): Observable<any> {
    return this.http.get<any>("https://localhost:7232/api/Alan");
  }
}

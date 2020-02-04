import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaderResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { IAbout } from 'src/app/Interfaces/about';

@Injectable({
  providedIn: 'root'
})
export class PerAppService {

  constructor(private http: HttpClient) { }

  getAbout(): Observable<IAbout[]>{
    return this.http.get<IAbout[]>('https://localhost:44342/api/about/getabout');
  }
}

import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaderResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { IAbout } from 'src/app/Interfaces/about';
import { IProject } from 'src/app/Interfaces/project';
import { ICourse } from 'src/app/Interfaces/course';

@Injectable({
  providedIn: 'root'
})
export class PerAppService {

  constructor(private http: HttpClient) { }

  getAbout(): Observable<IAbout[]>{
    return this.http.get<IAbout[]>('https://localhost:44342/api/about/getabout');
  }

  getProjects(): Observable<IProject[]>{
    return this.http.get<IProject[]>('https://localhost:44342/api/project/getprojects');
  }

  getCourses(): Observable<ICourse[]>{
    return this.http.get<ICourse[]>('https://localhost:44342/api/course/getallcourses');
  }


  errorHandler(error: HttpErrorResponse) {
    console.error(error);
    return throwError(error.message || "Server Error");
  }
}

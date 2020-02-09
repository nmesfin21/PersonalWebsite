import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { ICourse } from 'src/app/Interfaces/course';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AdminService {

  constructor(private http: HttpClient) { }

  addCourse(courseName: string, courseDescription: string, courseLink: string, semester: string): Observable<string>{
    var course: ICourse;
    course = {CourseId: undefined, CourseName: courseName, CourseDescription: courseDescription, CourseLink: courseLink, Semester:semester};
    return this.http.post<string>('https://localhost:44342/api/course/addcourse', course).pipe(catchError(this.errorHandler));
  }

  errorHandler(error: HttpErrorResponse) {
    console.error(error);
    return throwError(error.message || "Server Error");
  }
}

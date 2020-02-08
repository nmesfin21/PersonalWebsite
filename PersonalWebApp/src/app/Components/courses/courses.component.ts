import { Component, OnInit } from '@angular/core';
import { PerAppService } from 'src/app/Services/Perhttpservice/per-app.service';
import { ICourse } from 'src/app/Interfaces/course';

@Component({
  selector: 'app-courses',
  templateUrl: './courses.component.html',
  styleUrls: ['./courses.component.css']
})
export class CoursesComponent implements OnInit {
  courses: ICourse[];
  error: any;
  showError: boolean = false;
  constructor(private _aboutHttpSerice: PerAppService) { }

  ngOnInit() {
    this.getCourses();
  }

  async getCourses(){
    await this._aboutHttpSerice.getCourses().subscribe(
      response =>{
        this.courses = response;
        
      },
      error =>{
        this.error = error;
        console.log(this.error)
        this.showError = true;
      },
      () => console.log('course fetched')
    );
  }

  followLink(){
    window.open("https://www.google.com/")
  }

}

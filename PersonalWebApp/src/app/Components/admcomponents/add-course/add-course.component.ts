import { Component, OnInit } from '@angular/core';
import { AdminService } from 'src/app/Services/AdminService/admin.service';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-course',
  templateUrl: './add-course.component.html',
  styleUrls: ['./add-course.component.css']
})
export class AddCourseComponent implements OnInit {

  constructor(private _adminService: AdminService, private router: Router) { }

  ngOnInit() {
  }

  addCourse(form:NgForm){
    this._adminService.addCourse(form.value.courseName, form.value.courseDesc,form.value.courseLink, form.value.courseSemester).subscribe(
      response =>{
        console.log(response);
        alert('Course is added');
        this.router.navigate(['/courses'])

      },
      responseError =>{
        alert("failed to add course");
        console.log(responseError);
      },
      ()=>console.log('successful')
    )
  }
}

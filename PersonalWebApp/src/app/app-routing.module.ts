import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './Components/home/home.component';
import { ProjectsComponent } from './Components/projects/projects.component';
import { CoursesComponent } from './Components/courses/courses.component';
import { AddCourseComponent } from './Components/admcomponents/add-course/add-course.component';


const routes: Routes = [
  {path: 'home', component:HomeComponent},
  {path: 'projects', component:ProjectsComponent},
  {path: 'courses', component:CoursesComponent},
  {path: 'addcourse', component:AddCourseComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

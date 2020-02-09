import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CoursesComponent } from './Components/courses/courses.component';
import { ProjectsComponent } from './Components/projects/projects.component';
import { HomeComponent } from './Components/home/home.component';
import { TopNavComponent } from './Components/top-nav/top-nav.component';
import { AddCourseComponent } from './Components/admcomponents/add-course/add-course.component';
import {FormsModule} from '@angular/forms';


@NgModule({
  declarations: [
    AppComponent,
    CoursesComponent,
    ProjectsComponent,
    HomeComponent,
    TopNavComponent,
    AddCourseComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

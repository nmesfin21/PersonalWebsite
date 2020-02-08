import { Component, OnInit } from '@angular/core';
import { PerAppService } from 'src/app/Services/Perhttpservice/per-app.service';
import { IProject } from 'src/app/Interfaces/project';

@Component({
  selector: 'app-projects',
  templateUrl: './projects.component.html',
  styleUrls: ['./projects.component.css']
})
export class ProjectsComponent implements OnInit {
  projects: IProject[];
  error: any;
  showError: boolean = false;

  constructor(private _httpService: PerAppService) { }

  ngOnInit() {
    this.getProjects();
  }

  async getProjects(){
    await this._httpService.getProjects().subscribe(
      response =>{
        this.projects = response;
        console.log('project fteched')
      },
      error =>{
        this.error = error;
        this.showError = true;
        console.log(this.error);
      },
      ()=>console.log('project fetched')
    )
  }

 



}

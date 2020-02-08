import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-top-nav',
  templateUrl: './top-nav.component.html',
  styleUrls: ['./top-nav.component.css']
})
export class TopNavComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit() {
  }

  navbaropen = false;

  toggleNavbar(){
    this.navbaropen = !this.navbaropen;
  }

  getResume(){
    window.open("../assets/images/Resume2.0.pdf");
  }

  goAbout(){}

  goProjects(){
    this.router.navigate(['/projects']);
  }

  goCourse(){}

}

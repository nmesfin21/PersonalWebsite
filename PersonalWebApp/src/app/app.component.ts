import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'PersonalWebApp';

  navbaropen = false;

  toggleNavbar(){
    this.navbaropen = !this.navbaropen;
  }

  getResume(){
    window.open("Resume2.0.pdf", '_blank');
  }
}

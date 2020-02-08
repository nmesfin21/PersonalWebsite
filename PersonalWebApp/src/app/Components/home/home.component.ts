import { Component, OnInit } from '@angular/core';
import { PerAppService } from 'src/app/Services/Perhttpservice/per-app.service';
import { IAbout } from 'src/app/Interfaces/about';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  about: IAbout[];
  firstIndex: IAbout
  error: any;
  constructor(private _aboutHttpSerice: PerAppService) { }

  ngOnInit() {
    this.getAbout();


  }

  
 async getAbout(){
    await this._aboutHttpSerice.getAbout().subscribe(
      response =>{
        this.about = response;
        this.firstIndex = this.about[0];
        console.log('about: ' + this.firstIndex )
      },
      error =>{
        this.error = error;
        console.log(this.error)
      },
      () => console.log('everything went okay')
    );
  }

}

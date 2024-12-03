import { HttpClient, HttpClientModule, provideHttpClient, withFetch } from '@angular/common/http';
import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { RocketService } from './Rocket.service';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-root',
  imports: [HttpClientModule, DatePipe],
  providers:[],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  rocketMsg:any = {};

  constructor(private rocketService:RocketService,private http: HttpClient){
    this.getRocketMsgRequest();
  }


  getRocketMsgRequest():any{
    this.http.get<any>('http://localhost:3400/api/Rocket/GetRocketLunchingMessage').subscribe((data) => {
      this.rocketMsg = data;
    });
  }
  

}

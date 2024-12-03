import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class RocketService {

constructor(private http: HttpClient) { }

getRocketMsgRequest():any{
  this.http.get<any>('http://localhost:3400/api/Rocket');
}

}

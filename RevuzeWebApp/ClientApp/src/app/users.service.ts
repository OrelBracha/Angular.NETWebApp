import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IUsername } from './username';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  private _url: string = "https://localhost:5001/api/DataDivide";

  constructor(private http: HttpClient) { }


  getUsername() : Observable<IUsername[]>
  {
    return this.http.get<IUsername[]>(this._url);
  }
}

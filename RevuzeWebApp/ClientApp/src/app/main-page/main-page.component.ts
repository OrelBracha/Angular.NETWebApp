import { Component,Inject,OnInit } from '@angular/core';
import { HttpClient, HttpRequest, HttpEventType, HttpResponse, HttpHeaders } from '@angular/common/http';
import { UsersService } from '../users.service';
import {IUsername} from '../username';
import { IUserdet } from '../userdet';

 




@Component({
  selector: 'app-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.css']
})
export class MainPageComponent implements OnInit {
  baseUrl: string;
  userdetails: any;
  userlist: IUsername
  

  constructor(private _usersService: UsersService) { }
  ngOnInit(): void {
    this._usersService.getUsername().subscribe(data => {
      console.log(data)
      this.userdetails = data;

      console.log(this.userdetails);
      console.log(this.userdetails[0]);
      console.log(this.userdetails[1]);
      console.log(this.userdetails[2]);
      console.log(this.userdetails[3]);
      /*
      var group1 = this.userdetails[0];
      var group2 = this.userdetails[1];
      var group3 = this.userdetails[2];
      var group4 = this.userdetails[3];
      */
      
      
      
    });
  }




  public checkJsonGroup1()
  {
   
    this.userlist = this.userdetails[0];
    
  }

  public checkJsonGroup2()
  {
    
    this.userlist = this.userdetails[1];
    
  }

  public checkJsonGroup3()
  {
    this.userlist = this.userdetails[2];
  }

  public checkJsonGroup4()
  {
    this.userlist = this.userdetails[3];
  }
 


  public onuserclick(item)
  {
    var birth = item.birth_date;
    var addrees = item.address;
    
    
  }
}

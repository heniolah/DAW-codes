import { Component, OnInit, Injectable } from '@angular/core';
import { Http, ResponseContentType } from '@angular/http';
import { environment } from 'src/environments/environment';
import { map, tap } from "rxjs/operators";

@Injectable({
  providedIn: 'root'
})

@Component({
  selector: 'app-user-component', ///app-root
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {
  user = "";
  constructor(private http: Http) {
  }

  ngOnInit() {
  }

  isLoggined(): boolean {
    return this.user !== "";
  }
    Logout(){
      this.user = "";
  }

  Login(username, password) {
    let body = new FormData()
    body.append('username', username);
    body.append('password', password);

    let httpOptions = {
      responseType: ResponseContentType.Text
    }
    return this.http.post(`${environment.baseUrl}/user`, body, httpOptions).pipe(
         map(response => response.json()),
         tap(response => {
         if (response.status === "success")
           this.user = response.token;
         return response;
         })
    );
  }
}

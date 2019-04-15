import { Component, OnInit,Inject } from '@angular/core';
import { Router } from '@angular/router';
import { UserComponent  } from 'src/app/User/user.component';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})

export class LoginComponent implements OnInit {

  username = "abc";
  password = "123";

  message = "";
  constructor(private router: Router,
    private userservice: UserComponent ) { }
  //constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string,
  //  private userservice: UserComponent) { baseUrl + '/Login' }

  ngOnInit() {
  }
  Login() {
    this.userservice.Login(this.username, this.password).subscribe(response => {
      if (response.status === "error")
        this.message = response.message;
      else
        this.router.navigateByUrl('/dashboard');
    });
  }
}

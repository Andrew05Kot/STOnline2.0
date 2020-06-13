import { Component } from '@angular/core';
import {AuthService} from "./auth/auth.service";
import {Router} from "@angular/router";
import {GlobalConstants} from "./shared/global-constants";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'FRONTEND';
  isLogin: boolean =  GlobalConstants.login;

  constructor(public auth: AuthService, private router: Router) {
    this.isLogin = GlobalConstants.login;
  }

  onLogout(){
    localStorage.removeItem('token');
    this.router.navigate(['user/login']);
    GlobalConstants.login = false;
  }

}

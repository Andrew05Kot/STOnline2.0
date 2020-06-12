import { Component } from '@angular/core';
import {AuthService} from "./auth/auth.service";
import {Router} from "@angular/router";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'FRONTEND';
  constructor(public auth: AuthService, private router: Router) {
  }

  onLogout(){
    localStorage.removeItem('token');
    this.router.navigate(['user/login']);
  }

}

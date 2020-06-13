import { Component, OnInit } from '@angular/core';
import {NgForm} from "@angular/forms";
import {UserService} from "../../services/user.service";
import {Router} from "@angular/router";
import {ToastrService} from "ngx-toastr";
import {AuthService} from "../../auth/auth.service";
import {GlobalConstants} from "../../shared/global-constants";

interface ClientError {
  code: string;
  description: string;
}

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  formModel = {
    Email: '',
    Password: ''
  }

  constructor(public service: UserService, private router: Router,
              private toastr: ToastrService, private authService : AuthService) { }

  ngOnInit(): void {
    if(localStorage.getItem('token') != null){
      this.router.navigate(['/user']);
    }
  }

  onSubmit(form: NgForm){
    this.service.login(form.value).subscribe(
      (res: any) => {
        localStorage.setItem('token', res.token);
        this.service.loginModel.reset();
        this.toastr.success('Welcome!');
        this.router.navigate(['/user']);
      },
      err => {
        if(err.status == 400){
          this.toastr.error('Incorrect email or password.', 'Authentication failed.');
        } else {
          console.log(err);
        }
      }
    );
  }

}

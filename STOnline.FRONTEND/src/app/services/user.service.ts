import { Injectable } from '@angular/core';
import {FormBuilder, FormGroup, Validators} from "@angular/forms";
import {HttpClient, HttpHeaders} from "@angular/common/http";
import {GlobalConstants} from "../shared/global-constants";

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private fb: FormBuilder, private http: HttpClient) { }
  readonly BaseURL = GlobalConstants.BaseURL;

  public formModel = this.fb.group({
    UserName : ['', Validators.required],
    FullName : ['', Validators.required],
    Email: ['', Validators.email],
    Passwords: this.fb.group({
      Password: ['', [Validators.required, Validators.minLength(4)]],
      ConfirmPassword: ['', Validators.required]
    },
      {validator : this.comparePasswords})
  });

  public loginModel = this.fb.group({
    Email: ['', Validators.email],
    Password: ['', [Validators.required, Validators.minLength(4)]]
  });

  public comparePasswords(fb:FormGroup){
    let confirmPswrdCtrl = fb.get('ConfirmPassword')
    if (confirmPswrdCtrl.errors == null || 'passwordMismatch' in confirmPswrdCtrl.errors){
      if(fb.get('Password').value != confirmPswrdCtrl.value )
        confirmPswrdCtrl.setErrors( {passwordMismatch: true});
      else
        confirmPswrdCtrl.setErrors(null);
    }
  }

  register(){
    var body = {
      UserName: this.formModel.value.UserName,
      FullName: this.formModel.value.FullName,
      Email: this.formModel.value.Email,
      Password: this.formModel.value.Passwords.Password
    };
    return  this.http.post(this.BaseURL + '/Register', body);
  }

  public login(formData){
    GlobalConstants.login = true;
    return this.http.post(this.BaseURL + '/Login', formData);

  }

  getUserProfile(){
    return  this.http.get(this.BaseURL + '/UserProfile');
  }

}

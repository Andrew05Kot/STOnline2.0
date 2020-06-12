import { Injectable } from '@angular/core';
import {FormBuilder, FormGroup, Validators} from "@angular/forms";
import {HttpClient, HttpHeaders} from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private fb: FormBuilder, private http: HttpClient) { }
  readonly BaseURL = 'https://localhost:44380';

  public formModel = this.fb.group({
    UserName : ['', Validators.required],
    Email: ['', Validators.email],
    Passwords: this.fb.group({
      Password: ['', [Validators.required, Validators.minLength(4)]],
      ConfirmPassword: ['', Validators.required]
    },
      {validator : this.comparePasswords})
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

  public loginModel = this.fb.group({
    Email: ['', Validators.email],
    Password: ['', [Validators.required, Validators.minLength(4)]]
  });

  public register(){
    let body = {
      UserName: this.formModel.value.UserName,
      Email: this.formModel.value.Email,
      Password: this.formModel.value.Passwords.Password
    };
    return this.http.post(this.BaseURL + '/Register', body);
  }

  public login(formData){
    return this.http.post(this.BaseURL + '/Login', formData);
  }

  getUserProfile(){
    const userToken = localStorage.getItem('token');
    return  this.http.get(this.BaseURL + '/UserProfile', {headers: {'Authorization': 'Bearer ' + userToken, }});
  }

}

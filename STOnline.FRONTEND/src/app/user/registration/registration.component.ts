import { Component, OnInit } from '@angular/core';
import {UserService} from "../../services/user.service";
import {element} from "protractor";
import {ToastrService} from "ngx-toastr";

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {

  constructor(public service: UserService, private toastr : ToastrService) { }

  ngOnInit(): void {
  }

  onSubmit(){
    this.service.register().subscribe(
      (res: any) =>{
        if(res.successed) {
          this.service.formModel.reset();
          this.toastr.success('New user created!', 'Registration successful.')
        } else {
          res.errors.forEach(element => {
            switch (element.code) {
              case 'DuplicateUserName' :
                this.toastr.error('Username is already exist', 'Registration failed');
                break;
              default:
                this.toastr.error(element.description, 'Registration failed');
                break;
            }
          })
        }
      },
      err => {
        console.log(err);
        }
      )
  }

}

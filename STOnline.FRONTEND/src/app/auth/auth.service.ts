import {Injectable} from "@angular/core";
import {GlobalConstants} from "../shared/global-constants";

@Injectable({providedIn: 'root'})
export class AuthService {

  public login() : boolean{
    return  GlobalConstants.login;
  }

}

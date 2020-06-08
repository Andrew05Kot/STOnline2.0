import {Injectable} from "@angular/core";

@Injectable({providedIn: 'root'})
export class AuthService {
  private isAuth = false

  login() : boolean {
    this.isAuth = true
    return true;
  }

  logout(){
    this.isAuth = false
  }

  isAuthenticated(): Promise<boolean> {
    return new Promise( resolve => {
      setTimeout( () => {
        resolve(this.isAuth)
      }, 1000)
    })
  }
}

import {HttpEvent, HttpHandler, HttpInterceptor, HttpRequest} from "@angular/common/http";
import {Injectable} from "@angular/core";
import {Observable} from "rxjs";
import {tap} from "rxjs/operators";
import {Router} from "@angular/router";

@Injectable()
export class AuthInterceptor implements HttpInterceptor{

  constructor(private router: Router) {
  }

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    if(localStorage.getItem('token') != null){
      const userToken = localStorage.getItem('token');
      const cloneReq = req.clone({
        headers : req.headers.set('Authorization', 'Bearer ' + userToken )
      });
      return next.handle(cloneReq).pipe(
        tap(
          succ => {},
          err => {
            if (err.status == 401){
              localStorage.removeItem('token');
              this.router.navigate(['user/login']);
            }
          }
        )
      )
    }
    else {
      return next.handle(req.clone());
    }
  }

}

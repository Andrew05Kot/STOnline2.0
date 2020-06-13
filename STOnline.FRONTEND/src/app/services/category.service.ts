import { Injectable } from '@angular/core';
import {GlobalConstants} from "../shared/global-constants";
import {FormBuilder} from "@angular/forms";
import {HttpClient} from "@angular/common/http";
import {Category} from "../shared/interfaces/interfaces";
import {Observable} from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  list : Category[];

  readonly BaseURL = GlobalConstants.BaseURL;

  constructor(private fb: FormBuilder, private http: HttpClient) { }

  getCategories(page: number, size: number) : Observable<any>{
    return this.http.get<any>(this.BaseURL + '/CategoryesP?PageNumber=' + page + '&PageSize=' + size);
  }

  getCategoriesAsk(page: number, size: number) : Observable<any>{
    return this.http.get<any>(this.BaseURL + '/CategoryesP?PageNumber=' + page + '&PageSize=' + size + '?OrderBy=ask');
  }
  getCategoriesDesk(page: number, size: number) : Observable<any>{
    return this.http.get<any>(this.BaseURL + '/CategoryesP?PageNumber=' + page + '&PageSize=' + size + '?OrderBy=desk');
  }

  getCategoriesCount() : Observable<number>{
    return this.http.get<number>(this.BaseURL + '/Categoryes/Count');
  }
}

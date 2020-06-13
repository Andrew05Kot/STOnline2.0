import { Injectable } from '@angular/core';
import {GlobalConstants} from "../shared/global-constants";
import {FormBuilder} from "@angular/forms";
import {HttpClient} from "@angular/common/http";
import {Category} from "../shared/interfaces/interfaces";

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  list : Category[];

  readonly BaseURL = GlobalConstants.BaseURL;

  constructor(private fb: FormBuilder, private http: HttpClient) { }

  getCategories() {
    return this.http.get(this.BaseURL + '/CategoryesP')
      .toPromise()
      .then(res => this.list = res as Category[]);
  }
}

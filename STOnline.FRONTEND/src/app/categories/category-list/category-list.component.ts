import { Component, OnInit } from '@angular/core';
import {CategoryService} from "../../services/category.service";
import {Category} from "../../shared/interfaces/interfaces";
import {Observable} from "rxjs";

@Component({
  selector: 'app-category-list',
  templateUrl: './category-list.component.html',
  styleUrls: ['./category-list.component.css']
})
export class CategoryListComponent implements OnInit {

  list : Category[];
  public size: number = 4;
  public page: number = 1;
  public collectionSize: any;
  public some: any;

  constructor(public service: CategoryService) {
    this.list =  new Array<any>();
    this.service.getCategoriesCount().subscribe(
      res => {
        this.collectionSize = res;
        console.log('========' + this.collectionSize);
      }
    )

  }

  ngOnInit(): void {
    this.service.getCategories(this.page, this.size).subscribe( list => {
      this.list = list;
    },
    err => {
      console.log(err);
    })
  }

  onPageChanged(pageNumber, size){
    this.service.getCategories(pageNumber, size).subscribe( list => {
        this.list = list;
      },
      err => {
        console.log(err);
      })
    console.log("page changed: " + pageNumber);
  }

}

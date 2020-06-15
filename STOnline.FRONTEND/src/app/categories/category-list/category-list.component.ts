import {Component, EventEmitter, OnInit, Output} from '@angular/core';
import {CategoryService} from "../../services/category.service";
import {Category} from "../../shared/interfaces/interfaces";
import {FormControl, FormGroup, NgForm} from "@angular/forms";

@Component({
  selector: 'app-category-list',
  templateUrl: './category-list.component.html',
  styleUrls: ['./category-list.component.css']
})
export class CategoryListComponent implements OnInit {

  form: FormGroup;

  list : Category[];
  public size: number = 4;
  public page: number = 1;
  public collectionSize: any;

  constructor(public service: CategoryService) {
    this.list =  new Array<any>();
    this.service.getCategoriesCount().subscribe(
      res => {
        this.collectionSize = res;
        console.log(this.collectionSize);
      }
    )
  }

  ngOnInit(): void {
    this.form = new FormGroup({
      categoryName: new FormControl('')
    });
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

  delete(id: number){
    this.service.deleteCategory(id).subscribe(
      res => {
        this.refresh();
      },
      err => {
        console.log(err);
      }
    )
  }

  post(){
    const category: Category = {...this.form.value};
    this.service.postCategory(category).subscribe(
      res => {
        this.refresh();
        this.form.reset();
      },
      err => {
        console.log(err);
      }
    );
  }

  edit(category){
    this.form.setValue(category);
  }

  refresh(){
    this.service.getCategoriesCount().subscribe(
      res => {
        this.collectionSize = res;
        console.log(this.collectionSize);
      })
    this.service.getCategories(this.page, this.size).subscribe( list => {
      this.list = list;
    })
  }
}

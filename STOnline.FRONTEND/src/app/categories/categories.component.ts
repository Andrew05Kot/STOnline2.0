import { Component, OnInit } from '@angular/core';
import {CategoryService} from "../services/category.service";
import {Category} from "../shared/interfaces/interfaces";

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.css']
})
export class CategoriesComponent implements OnInit {

  // list : Category[];

  constructor(public service: CategoryService) { }

  ngOnInit(): void {
    // this.list = this.service.getCategories();
  }
}

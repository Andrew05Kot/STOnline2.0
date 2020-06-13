import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomePageComponent } from './home-page/home-page.component';
import { NotFoundPageComponent } from './not-found-page/not-found-page.component';
import { UserComponent } from './user/user.component';
import { RegistrationComponent } from './user/registration/registration.component';
import {FormsModule, ReactiveFormsModule} from "@angular/forms";
import {UserService} from "./services/user.service";
import {HTTP_INTERCEPTORS, HttpClientModule} from "@angular/common/http";
import {ToastrModule} from "ngx-toastr";
import { LoginComponent } from './user/login/login.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {AuthInterceptor} from "./auth/auth.interceptor";
import { OrderComponent } from './orders/order/order.component';
import {LocalizationModule} from "./shared/localization/localization.module";
import { CategoryComponent } from './categories/category/category.component';
import { CategoriesComponent } from './categories/categories.component';
import { CategoryListComponent } from './categories/category-list/category-list.component';
import {CategoryService} from "./services/category.service";
import {NgxPaginationModule} from "ngx-pagination";
import {NgbPaginationModule} from "@ng-bootstrap/ng-bootstrap";
import { OrdersComponent } from './orders/orders.component';

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    NotFoundPageComponent,
    UserComponent,
    RegistrationComponent,
    LoginComponent,
    OrderComponent,
    CategoryComponent,
    CategoriesComponent,
    CategoryListComponent,
    OrdersComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    ToastrModule.forRoot(),
    FormsModule,
    LocalizationModule,
    BrowserAnimationsModule,
    NgxPaginationModule,
    NgbPaginationModule
  ],
  providers: [UserService,
    {
    provide: HTTP_INTERCEPTORS,
    useClass: AuthInterceptor,
    multi: true
    },
    CategoryService],
  bootstrap: [AppComponent]
})
export class AppModule { }

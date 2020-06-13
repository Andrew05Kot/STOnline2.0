import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {HomePageComponent} from "./home-page/home-page.component";
import {NotFoundPageComponent} from "./not-found-page/not-found-page.component";
import {UserComponent} from "./user/user.component";
import {RegistrationComponent} from "./user/registration/registration.component";
import {LoginComponent} from "./user/login/login.component";
import {AuthGuard} from "./auth/auth.guard";
import {CategoryComponent} from "./categories/category/category.component";
import {CategoriesComponent} from "./categories/categories.component";
import {OrderComponent} from "./orders/order/order.component";
import {OrdersComponent} from "./orders/orders.component";


const routes: Routes = [
  {path:'', redirectTo:'/user/registration', pathMatch:'full'},
  {path: 'home', component: HomePageComponent},
  {path: 'user', component: UserComponent, canActivate:[AuthGuard]},
  {path: 'user/registration', component: RegistrationComponent},
  {path: 'user/login', component: LoginComponent},
  {path: 'not-found', component: NotFoundPageComponent},
  {path: 'categories', component: CategoriesComponent},
  {path: 'order', component: OrderComponent},
  {path: 'orders', component: OrdersComponent},
  {path: '**', redirectTo: 'not-found'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {HomePageComponent} from "./home-page/home-page.component";
import {NotFoundPageComponent} from "./not-found-page/not-found-page.component";
import {UserComponent} from "./user/user.component";
import {RegistrationComponent} from "./user/registration/registration.component";


const routes: Routes = [
  {path:'', redirectTo:'/user/registration', pathMatch:'full'},
  {path: 'home', component: HomePageComponent},
  {path: 'user', component: UserComponent},
  {path: 'user/registration', component: RegistrationComponent},
  {path: 'not-found', component: NotFoundPageComponent},
  {path: '**', redirectTo: 'not-found'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

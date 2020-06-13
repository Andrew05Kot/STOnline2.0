import { Component } from '@angular/core';
import {AuthService} from "./auth/auth.service";
import {Router} from "@angular/router";
import {GlobalConstants} from "./shared/global-constants";
import {LocalizationService} from "./shared/localization/localization.service";
import {TranslateService} from "@ngx-translate/core";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [LocalizationService]
})
export class AppComponent {
  title = 'FRONTEND';

  isLogin: boolean =  GlobalConstants.login;
  localizationService: LocalizationService;

  constructor(public translateService: TranslateService, public auth: AuthService,
              private router: Router, localizationService: LocalizationService) {
    translateService.addLangs(['uk', 'en']);
    this.localizationService = localizationService;
    this.localizationService.initLanguage(window.navigator.language);
    this.isLogin = GlobalConstants.login;
  }

  switchLang(languageTag: string) {
    this.localizationService.translateService.setDefaultLang('uk');
    this.localizationService.switchLanguage(languageTag);
  }


  onLogout(){
    localStorage.removeItem('token');
    this.router.navigate(['user/login']);
    GlobalConstants.login = false;
  }

}

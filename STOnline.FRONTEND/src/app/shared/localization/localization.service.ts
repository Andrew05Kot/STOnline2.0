import {Injectable} from '@angular/core';
import {Subject, Subscription} from 'rxjs';
import {TranslateService} from '@ngx-translate/core';

@Injectable()
export class LocalizationService {

  availableLanguages = ['uk', 'en'];
  private subject = new Subject();
  private languageChangeEvent = this.subject.asObservable();
  translateService: TranslateService;

  constructor(translateService: TranslateService) {
    this.translateService = translateService;
  }

  subscribeLanguageChange(callback): Subscription {
    return this.languageChangeEvent.subscribe(callback);
  }

  triggerLanguageChange() {
    this.subject.next();
  }

  initLanguage(langFromWindowNavigator: string) {
    this.translateService.setDefaultLang('uk');
    let lang = localStorage.getItem('lang');
    if (lang) {
      this.translateService.use(lang);
    } else {
      let browserLang = langFromWindowNavigator.substr(0, 2);
      if (this.availableLanguages.indexOf(browserLang) !== -1) {
        this.translateService.use(browserLang);
        localStorage.setItem('lang', browserLang);
      } else {
        localStorage.setItem('lang', 'uk');
      }
    }
  }

  switchLanguage(languageTag: string) {
    if (this.availableLanguages.indexOf(languageTag) !== -1 && localStorage.getItem('lang') !== languageTag) {
      localStorage.setItem('lang', languageTag);
      this.translateService.use(languageTag);
      this.triggerLanguageChange();
    }
  }
}

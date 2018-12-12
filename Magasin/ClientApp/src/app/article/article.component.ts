import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'article',
  templateUrl: './article.component.html'
})

export class ArticleComponent {
  public arts: any[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<any[]>(baseUrl + 'api/article').subscribe(result => this.arts = result);
  }
}

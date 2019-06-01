import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public films: Movies[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Movies[]>(baseUrl + 'api/SampleData/Movies').subscribe(result => {
      this.films = result;
    }, error => console.error(error));
  }
}

interface Movies {
  movieID: string;
  title: string;
  director: string;
  ticketPrice: string;
}

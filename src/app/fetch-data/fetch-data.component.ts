import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public film: Movies[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Movies[]>(baseUrl + 'api/SampleDataController/Movies').subscribe(result => {
      this.film = result;
    }, error => console.error(error));
  }
}


interface Movies {
  ID: number;
  title: string;
  director: string;
  ticketPrice: number;
}

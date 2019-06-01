"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
@Injectable()
export class MoviesService {
  constructor(
    private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }
  listMovies() {
    return this.http.get<Movie[]>(this.baseUrl + 'api/Movies/ListMovies');
  }
  loadMovie(movieID: string) {
    return this.http.get<Movie>(this.baseUrl + `api/Movies/DetailMovie?movieID=${movieID}`);
  }
  saveMovie(movie: Movie) {
    return this.http.post<any>(this.baseUrl + `api/Movies/SaveMovie`, movie);
  }
  deleteMovie(movieID: string) {
    return this.http.delete<any>(this.baseUrl + `api/Movies/DeleteMovie?movieID=${movieID}`);
  }
}
# sourceMappingURL=movies.service.js.map

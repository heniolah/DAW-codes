import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Movie } from './../movies.models';
import { MoviesService } from '../movies.service';

@Component({
  selector: 'app-movies-edit',
  templateUrl: './movies-edit.component.html',
  styleUrls: ['./movies-edit.component.css']
})
export class MoviesEditComponent implements OnInit {

  private routerLink: string = '../list';

  public movie: Movie;

  private movieID: string;

  private isEdit: boolean = false;

  public formGroup: FormGroup;

  private errorMessage: string;

  constructor(
    private router: Router,
    private route: ActivatedRoute,
    private moviesService: MoviesService,
    private formBuilder: FormBuilder) { }

  ngOnInit() {

    this.movieID = this.route.snapshot.params['id'];

    if (this.movieID) {
      this.routerLink = '../../list';
      this.isEdit = true;
    }

    this.moviesService.loadMovie(this.movieID).subscribe(res => {
      this.movie = res;
      this.initForm(this.movie ? this.movie : <Movie>{});
    });

  }

  save() {
    Object.keys(this.formGroup.controls).forEach(control => {
      this.formGroup.get(control).markAsTouched();
    });

    if (this.formGroup.valid) {
      let movie = this.formGroup.value as Movie;

      if (this.isEdit) {
        movie.id = this.movieID;
      }

      this.moviesService.saveMovie(movie).subscribe(res => {
        this.router.navigate(['/movies']);
      });
    }
  }




  initForm(movie: Movie) {
    this.formGroup = this.formBuilder.group({
      name: [movie.name, [Validators.required, Validators.maxLength(15)]],
    });
  }
}

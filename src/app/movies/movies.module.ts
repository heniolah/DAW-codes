import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AngularMaterialModule } from '../shared/angular-material.module';

import { CoreModule } from '../core/core.module';

import { MoviesService } from './movies.service';

import { MoviesRoutingModule } from './movies-routing.module';

@NgModule({
  declarations: [MoviesRoutingModule.routedComponents],
  imports: [
    CommonModule,
    FormsModule,
    HttpClientModule,
    AngularMaterialModule,
    ReactiveFormsModule,
    MoviesRoutingModule,
    CoreModule
  ],
  providers: [MoviesService]
})

export class MoviesModule { }

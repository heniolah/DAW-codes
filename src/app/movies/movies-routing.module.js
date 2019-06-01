"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
import { MoviesComponent } from "./movies.component";
import { MoviesListComponent } from "./movies-list/movies-list.component";
import { MoviesEditComponent } from './movies-edit/movies-edit.component';
const routes: Routes = [
  {
    path: '', component: MoviesComponent, data: { navArea: 'movie' },
    children: [
      { path: '', redirectTo: 'list', pathMatch: 'full' },
      { path: 'list', component: MoviesListComponent },
      { path: 'edit/:id', component: MoviesEditComponent },
      { path: 'edit', component: MoviesEditComponent },
    ]
  }
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
}) 
export class MoviesRoutingModule {
}
# sourceMappingURL=movies-routing.module.js.map

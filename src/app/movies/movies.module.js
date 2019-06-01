"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
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
# sourceMappingURL=movies.module.js.map

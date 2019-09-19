import { Route } from '@angular/router';
import { IndexComponent } from './index.component';

export const IndexRoutes: Route[] = [
    {
        path: '',
        component: IndexComponent,
        canActivate: [''],
        children: []
    }
]
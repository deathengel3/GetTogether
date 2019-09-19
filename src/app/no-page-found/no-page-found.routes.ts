import { Route } from '@angular/router';
import { NoPageFoundComponent } from './no-page-found.component';

export const NoPageFoundRoutes: Route[] = [
    {
        path: '',
        component: NoPageFoundComponent,
        canActivate: [''],
        children: []
    }
]
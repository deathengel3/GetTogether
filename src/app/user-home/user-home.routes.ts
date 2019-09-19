import { Route } from '@angular/router';
import { UserHomeComponent } from './user-home.component';

export const UserHomeRoutes: Route[] = [
    {
        path: '',
        component: UserHomeComponent,
        canActivate: [''],
        children: []
    }
]
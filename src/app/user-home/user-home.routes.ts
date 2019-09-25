import { Route } from '@angular/router';
import { UserHomeComponent } from './user-home.component';
import { AuthGuard } from '../_guards/auth.guard';

export const UserHomeRoutes: Route[] = [
    {
        path: '',
        component: UserHomeComponent,
        canActivate: [AuthGuard],
        children: [
            {
                path: '',
                loadChildren: () => import('./dashboard/dashboard.module').then(d => d.DashboardModule)
            },
            {
                path: 'votar',
                loadChildren: () => import('./votar/votar.module').then(v => v.VotarModule)
            }
        ]
    }
];
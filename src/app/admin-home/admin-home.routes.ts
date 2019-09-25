import { Route } from '@angular/router';
import { AdminHomeComponent } from './admin-home.component';
import { AuthGuard } from '../_guards/auth.guard';
import { Rol } from '../_models/rol';

export const AdminHomeRoutes: Route[] = [
    {
        path: '',
        component: AdminHomeComponent,
        canActivate: [AuthGuard],
        children: []
    }
]
import { Route } from '@angular/router';
import { IndexComponent } from './index.component';
import { LoginGuard } from '../_guards/login.guard';

export const IndexRoutes: Route[] = [
    {
        path: '',
        component: IndexComponent,
        canActivate: [LoginGuard],
        children: [
            {
                path: 'login',
                loadChildren: () => import('../index/login/login.module').then(i => i.LoginModule)
            },
            {
                path: 'forgot',
                loadChildren: () => import('../index/forgot/forgot.module').then(i => i.ForgotModule)
            }
        ]
    }
];
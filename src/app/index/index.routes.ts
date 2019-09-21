import { Route } from '@angular/router';
import { IndexComponent } from './index.component';

export const IndexRoutes: Route[] = [
    {
        path: '',
        component: IndexComponent,
        children: [
            {
                path: '',
                redirectTo: 'login',
                pathMatch: 'full'
            },
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
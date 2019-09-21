import { Routes } from '@angular/router';
import { IndexRoutes } from './index/index.routes';
import { AdminHomeRoutes } from './admin-home/admin-home.routes';
import { NoPageFoundRoutes } from './no-page-found/no-page-found.routes';
import { UserHomeRoutes } from './user-home/user-home.routes';

export const routes: Routes = [...IndexRoutes, ...AdminHomeRoutes, ...UserHomeRoutes, ...NoPageFoundRoutes];
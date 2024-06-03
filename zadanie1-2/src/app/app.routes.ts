import { Routes } from '@angular/router';
import { LogowanieComponent } from './logowanie/logowanie.component';
import { DashboardComponent } from './dashboard/dashboard.component';

export const routes: Routes = [
    { path: '', component: LogowanieComponent},
    { path: 'dashboard', component: DashboardComponent}
];
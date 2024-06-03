import { Component } from '@angular/core';
import { MenuComponent } from '../menu/menu.component';
import { NgIf } from '@angular/common';
//import { NgIf } from '@angular/common';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [MenuComponent, NgIf],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.css'
})
export class DashboardComponent {
  constructor(private authService: AuthService) { }
  isLoggedIn = this.authService.isLoggedIn;
}

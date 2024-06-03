import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AuthService } from '../auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-logowanie',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './logowanie.component.html',
  styleUrl: './logowanie.component.css'
})
export class LogowanieComponent {
  formData = {
    username: '',
    password: ''
  };

  zalogowany = false;

  constructor(private authService: AuthService, private router: Router) { }



  logowanie() {
    if(this.formData.username === 'exampleUser' && this.formData.password === 'validPassword') {
      console.log('Zalogowano pomyslnie');
      this.zalogowany = true;
      this.authService.login();
      this.router.navigate(['dashboard']);
    } else {
      console.log('blad logowania, sprawdz dane');
      }
  }
}


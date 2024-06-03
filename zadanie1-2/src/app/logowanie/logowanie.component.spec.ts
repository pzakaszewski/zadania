import { ComponentFixture, TestBed } from '@angular/core/testing';
import { LogowanieComponent } from './logowanie.component';

describe('LogowanieComponent', () => {
  let component: LogowanieComponent;
  let fixture: ComponentFixture<LogowanieComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [LogowanieComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(LogowanieComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should have a form with required fields', () => {
    const usernameField = fixture.debugElement.nativeElement.querySelector('input[name="username"]');
    const passwordField = fixture.debugElement.nativeElement.querySelector('input[name="password"]');
    const submitButton = fixture.debugElement.nativeElement.querySelector('button[type="submit"]');

    expect(usernameField).toBeTruthy();
    expect(passwordField).toBeTruthy();
    expect(submitButton).toBeTruthy();
    expect(usernameField.getAttribute('required')).toBe('');
    expect(passwordField.getAttribute('required')).toBe('');
  });

  it('should call logowanie() method when form is submitted', () => {
    spyOn(component, 'logowanie');
    const form = fixture.debugElement.nativeElement.querySelector('form');
    form.dispatchEvent(new Event('submit'));
    fixture.detectChanges();
    expect(component.logowanie).toHaveBeenCalled();
  });

  it('should set zalogowany variable to true after successful login', () => {
      component.formData.username = 'exampleUser';
      component.formData.password = 'validPassword';
      
      component.logowanie();
    
      expect(component.zalogowany).toBeTrue();
  });
});
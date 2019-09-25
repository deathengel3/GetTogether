import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from '../../_services'
import { first } from 'rxjs/internal/operators/first';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  hide = true;
  loginForm: FormGroup;
  usuario: string;
  password: string;
  submitted = false;
  returnUrl = "";
  
  constructor(private formBuilder: FormBuilder,
              private route: ActivatedRoute,
              private router: Router,
              private authService: AuthService) { 
    //Comprobar la sessión
  }

  ngOnInit() {
    this.loginForm = this.formBuilder.group({
      usuario: ['', Validators.required],
      password: ['', Validators.required],
    });
  }
  get f(){ return this.loginForm.controls }

  onSubmit(): void{
    debugger;
    this.submitted = true;
    
    if(this.loginForm.invalid)
      return;
    
      this.authService.login(this.f.usuario.value, this.f.password.value)
        .pipe(first())
        .subscribe(
          data => {
            this.router.navigate(['/']);
          },
          error =>{
            this.submitted = false;
            alert('Nombre de usuario y/o contraseña incorrectos.')
          }
        );
    

  }



}

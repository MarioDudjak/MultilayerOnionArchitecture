import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent implements OnInit {
  model: any = {};
  constructor() { }

  ngOnInit() {
  }

  login(){
    //ovo treba maknuti
  }
  
  switchForms(){
    var loginForm = document.getElementById("loginForm");
    var registerForm = document.getElementById("registerForm");
    
    if (loginForm.style.display === "none") {
        loginForm.style.display = "block";
        registerForm.style.display="none";
      
    } else {
        loginForm.style.display = "none";
        registerForm.style.display="block";        
    }
  }

}

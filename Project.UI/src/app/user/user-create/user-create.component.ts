import { Component, OnInit } from '@angular/core';
import {User} from './../shared/user.model';
import {UserService} from './../shared/user.service';
@Component({
  selector: 'app-user-create',
  templateUrl: './user-create.component.html'
})

export class UserCreateComponent implements OnInit {
  private model: any = {};
  private user : User;
  constructor(private userService:UserService) { }

  ngOnInit() {
  }

  async registerAsync():Promise<void>{
    this.user = new User(this.model.email, this.model.username, this.model.password);
    await this.userService.createUserAsync(this.user);
  }
  
}

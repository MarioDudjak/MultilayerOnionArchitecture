import { NgModule }              from '@angular/core';
import {UserCreateComponent} from './user-create/user-create.component';
import {SharedModule} from './../shared/shared.module';
import {UserService} from './shared/user.service';
import {UserRoutingModule} from './user-routing.module';
  @NgModule({
    imports: [
    SharedModule,
    UserRoutingModule
    ],
    declarations:[UserCreateComponent],
    exports: [UserCreateComponent,
      UserRoutingModule
    ],
    providers:[UserService]
  })
  export class UserModule {}
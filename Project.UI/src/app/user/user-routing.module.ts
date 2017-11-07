import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";

import {UserCreateComponent} from './user-create/user-create.component';

@NgModule({
	imports: [
		RouterModule.forChild([
			{ path: "user/create", component: UserCreateComponent }
			
		]),
	],
	
	exports: [
		RouterModule
	]
})
export class UserRoutingModule {}

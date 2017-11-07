import { NgModule } from '@angular/core';
import { RouterModule } from "@angular/router";
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import {PageNotFoundComponent} from './error/page-not-found/not-found.component';
import { HomeComponent } from './home/home.component';
import {UserModule} from './user/user.module';
import {SharedModule} from './shared/shared.module';
@NgModule({
  declarations: [
    AppComponent,
    PageNotFoundComponent,
    HomeComponent
  ],
  imports: [
    AppRoutingModule,
    UserModule,
    SharedModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

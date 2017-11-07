import { NgModule }              from '@angular/core';
import { RouterModule, Routes }  from '@angular/router';
import { AppComponent } from './app.component';
import {PageNotFoundComponent} from './error/page-not-found/not-found.component';
import { HomeComponent } from './home/home.component';

const appRoutes: Routes = [
    { path: 'login',   component: HomeComponent },    
    { path: '',   redirectTo: '/login', pathMatch: 'full' },
    { path: '**', component: PageNotFoundComponent }
  ];
   
  @NgModule({
    imports: [
      RouterModule.forRoot(appRoutes)
    ],
    exports: [
      RouterModule
    ]
  })
  export class AppRoutingModule {}
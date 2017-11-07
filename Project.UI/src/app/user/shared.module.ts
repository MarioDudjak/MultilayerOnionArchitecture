import { NgModule } from '@angular/core';
import { FormsModule }   from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';


@NgModule({
  declarations: [
   
  ],
  imports: [
    FormsModule,
    BrowserModule,
    HttpModule    
  ],
  exports:[
    BrowserModule,    
    FormsModule,
    HttpModule
  ],
  providers: [],
})

export class SharedModule { }

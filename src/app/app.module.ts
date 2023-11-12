import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { InicioTuristaComponent } from './inicio-turista/inicio-turista.component';
import { IniciarSecionTuristaComponent } from './iniciar-secion-turista/iniciar-secion-turista.component';
import { RegistrarTuristaComponent } from './registrar-turista/registrar-turista.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { ButtonsModule } from 'ngx-bootstrap/buttons';
import { CommonModule } from '@angular/common';

@NgModule({
  declarations: [
    AppComponent,
    InicioTuristaComponent,
    IniciarSecionTuristaComponent,
    RegistrarTuristaComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    BsDropdownModule.forRoot(), 
    ButtonsModule.forRoot(),
    CommonModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { InicioTuristaComponent } from './componentes/inicio/inicio.component';
import { IniciarSecionTuristaComponent } from './componentes/iniciar-secion-turista/iniciar-secion-turista.component';
import { RegistrarTuristaComponent } from './componentes/registrar-turista/registrar-turista.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { ButtonsModule } from 'ngx-bootstrap/buttons';
import { CommonModule } from '@angular/common';
import { NavbarComponent } from './componentes/navbar/navbar.component';
import { IniciarSesionGuiaComponent } from './componentes/iniciar-sesion-guia/iniciar-sesion-guia.component';
import { IniciarSesionEstablecimientoComponent } from './componentes/iniciar-sesion-establecimiento/iniciar-sesion-establecimiento.component';
import { RegistrarEstablecimientoComponent } from './componentes/registrar-establecimiento/registrar-establecimiento.component';
import { RegistrarGuiaComponent } from './componentes/registrar-guia/registrar-guia.component';

@NgModule({
  declarations: [
    AppComponent,
    InicioTuristaComponent,
    IniciarSecionTuristaComponent,
    RegistrarTuristaComponent,
    NavbarComponent,
    IniciarSesionGuiaComponent,
    IniciarSesionEstablecimientoComponent,
    RegistrarEstablecimientoComponent,
    RegistrarGuiaComponent
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

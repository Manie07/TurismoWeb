import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CommonModule } from '@angular/common';
import { MainComponent } from './components/main/main.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { FooterComponent } from './components/footer/footer.component';
import { LoginComponent } from './components/login/login.component';
import { SitiosturisticosComponent } from './components/sitiosturisticos/sitiosturisticos.component';
import { RegistroturistaComponent } from './components/registroturista/registroturista.component';
import { RegistroestablecimientoComponent } from './components/registroestablecimiento/registroestablecimiento.component';
import { RegistroguiaComponent } from './components/registroguia/registroguia.component';




@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    NavbarComponent,
    FooterComponent,
    LoginComponent,
    SitiosturisticosComponent,
    RegistroturistaComponent,
    RegistroestablecimientoComponent,
    RegistroguiaComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    CommonModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { InicioTuristaComponent } from './inicio-turista/inicio-turista.component';
import { IniciarSecionTuristaComponent } from './iniciar-secion-turista/iniciar-secion-turista.component';
import { RegistrarTuristaComponent } from './registrar-turista/registrar-turista.component';

@NgModule({
  declarations: [
    AppComponent,
    InicioTuristaComponent,
    IniciarSecionTuristaComponent,
    RegistrarTuristaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

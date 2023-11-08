import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { InicioTuristaComponent } from './inicio-turista/inicio-turista.component';
import { IniciarSecionTuristaComponent } from './iniciar-secion-turista/iniciar-secion-turista.component';

@NgModule({
  declarations: [
    AppComponent,
    InicioTuristaComponent,
    IniciarSecionTuristaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

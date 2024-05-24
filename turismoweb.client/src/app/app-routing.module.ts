import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainComponent } from './components/main/main.component';
import { LoginComponent } from './components/login/login.component';
import { SitiosturisticosComponent } from './components/sitiosturisticos/sitiosturisticos.component';
import { RegistroturistaComponent } from './components/registroturista/registroturista.component';
import { RegistroguiaComponent } from './components/registroguia/registroguia.component';
import { RegistroestablecimientoComponent } from './components/registroestablecimiento/registroestablecimiento.component';


const routes: Routes = [
  { path: '', redirectTo: '/main', pathMatch: 'full' },
  { path: 'main', component: MainComponent },
  { path: 'main/login', component: LoginComponent },
  { path: 'main/sitiosturisticos', component: SitiosturisticosComponent },
  { path: 'main/registroturista', component: RegistroturistaComponent },
  { path: 'main/registroguia', component: RegistroguiaComponent },
  { path: 'main/registroestablecimiento', component: RegistroestablecimientoComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

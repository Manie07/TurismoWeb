import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InicioTuristaComponent } from './componentes/inicio/inicio.component';
import { RegistrarTuristaComponent } from './componentes/registrar-turista/registrar-turista.component';
import { IniciarSecionTuristaComponent } from './componentes/iniciar-secion-turista/iniciar-secion-turista.component';

const routes: Routes = [
  {path: '', redirectTo: '/inicio', pathMatch: 'full'},
  {path: 'inicio',component: InicioTuristaComponent},
  {path: 'registrar-turista',component: RegistrarTuristaComponent},
  {path: 'iniciar-secion-turista',component: IniciarSecionTuristaComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InicioTuristaComponent } from './componentes/inicio-turista/inicio-turista.component';

const routes: Routes = [
  {path: 'inicio-sesion',component: InicioTuristaComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

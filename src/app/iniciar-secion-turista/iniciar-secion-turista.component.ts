import { Component } from '@angular/core';

@Component({
  selector: 'app-iniciar-secion-turista',
  templateUrl: './iniciar-secion-turista.component.html',
  styleUrls: ['./iniciar-secion-turista.component.css']
})
export class IniciarSecionTuristaComponent {
// Componente Padre
mostrarComponente = false;

registrar() {
  this.mostrarComponente = !this.mostrarComponente;
}

}

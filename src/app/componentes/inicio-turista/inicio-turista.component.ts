import { Component } from '@angular/core';

@Component({
  selector: 'app-inicio-turista',
  templateUrl: './inicio-turista.component.html',
  styleUrls: ['./inicio-turista.component.css'],
})
export class InicioTuristaComponent {
  scrollToTop(event: Event) {
    event.preventDefault();
    window.scrollTo({ top: 0, behavior: 'smooth' });
  }
}

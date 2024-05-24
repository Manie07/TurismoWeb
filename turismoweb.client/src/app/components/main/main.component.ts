import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent {
  constructor(
    private router: Router
  ) { }

  ngOnInit(): void {

  }

  registroturista() {
    this.router.navigate(['main/registroturista']);
  }

  registroguia() {
    this.router.navigate(['main/registroguia']);
  }

  registroestablecimiento() {
    this.router.navigate(['main/registroestablecimiento']);
  }
}

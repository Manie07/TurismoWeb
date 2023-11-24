import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IniciarSesionGuiaComponent } from './iniciar-sesion-guia.component';

describe('IniciarSesionGuiaComponent', () => {
  let component: IniciarSesionGuiaComponent;
  let fixture: ComponentFixture<IniciarSesionGuiaComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [IniciarSesionGuiaComponent]
    });
    fixture = TestBed.createComponent(IniciarSesionGuiaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

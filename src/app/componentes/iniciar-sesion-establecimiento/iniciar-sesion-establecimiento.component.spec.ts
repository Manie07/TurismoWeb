import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IniciarSesionEstablecimientoComponent } from './iniciar-sesion-establecimiento.component';

describe('IniciarSesionEstablecimientoComponent', () => {
  let component: IniciarSesionEstablecimientoComponent;
  let fixture: ComponentFixture<IniciarSesionEstablecimientoComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [IniciarSesionEstablecimientoComponent]
    });
    fixture = TestBed.createComponent(IniciarSesionEstablecimientoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

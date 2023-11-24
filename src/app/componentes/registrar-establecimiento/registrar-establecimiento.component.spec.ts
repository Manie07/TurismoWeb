import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistrarEstablecimientoComponent } from './registrar-establecimiento.component';

describe('RegistrarEstablecimientoComponent', () => {
  let component: RegistrarEstablecimientoComponent;
  let fixture: ComponentFixture<RegistrarEstablecimientoComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [RegistrarEstablecimientoComponent]
    });
    fixture = TestBed.createComponent(RegistrarEstablecimientoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistrarGuiaComponent } from './registrar-guia.component';

describe('RegistrarGuiaComponent', () => {
  let component: RegistrarGuiaComponent;
  let fixture: ComponentFixture<RegistrarGuiaComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [RegistrarGuiaComponent]
    });
    fixture = TestBed.createComponent(RegistrarGuiaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

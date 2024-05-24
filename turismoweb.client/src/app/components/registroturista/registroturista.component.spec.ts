import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistroturistaComponent } from './registroturista.component';

describe('RegistroturistaComponent', () => {
  let component: RegistroturistaComponent;
  let fixture: ComponentFixture<RegistroturistaComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [RegistroturistaComponent]
    });
    fixture = TestBed.createComponent(RegistroturistaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

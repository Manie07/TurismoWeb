import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistroguiaComponent } from './registroguia.component';

describe('RegistroguiaComponent', () => {
  let component: RegistroguiaComponent;
  let fixture: ComponentFixture<RegistroguiaComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [RegistroguiaComponent]
    });
    fixture = TestBed.createComponent(RegistroguiaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

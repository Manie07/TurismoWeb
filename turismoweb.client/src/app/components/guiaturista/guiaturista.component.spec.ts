import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GuiaturistaComponent } from './guiaturista.component';

describe('GuiaturistaComponent', () => {
  let component: GuiaturistaComponent;
  let fixture: ComponentFixture<GuiaturistaComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [GuiaturistaComponent]
    });
    fixture = TestBed.createComponent(GuiaturistaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SitiosturisticosComponent } from './sitiosturisticos.component';

describe('SitiosturisticosComponent', () => {
  let component: SitiosturisticosComponent;
  let fixture: ComponentFixture<SitiosturisticosComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SitiosturisticosComponent]
    });
    fixture = TestBed.createComponent(SitiosturisticosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

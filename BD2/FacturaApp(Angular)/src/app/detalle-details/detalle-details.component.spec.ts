import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetalleDetailsComponent } from './detalle-details.component';

describe('DetalleDetailsComponent', () => {
  let component: DetalleDetailsComponent;
  let fixture: ComponentFixture<DetalleDetailsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DetalleDetailsComponent]
    });
    fixture = TestBed.createComponent(DetalleDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

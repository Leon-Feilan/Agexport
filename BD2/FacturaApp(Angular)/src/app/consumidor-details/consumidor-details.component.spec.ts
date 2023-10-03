import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConsumidorDetailsComponent } from './consumidor-details.component';

describe('ConsumidorDetailsComponent', () => {
  let component: ConsumidorDetailsComponent;
  let fixture: ComponentFixture<ConsumidorDetailsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ConsumidorDetailsComponent]
    });
    fixture = TestBed.createComponent(ConsumidorDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

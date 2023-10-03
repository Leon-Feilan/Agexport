import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormularioConsumidorComponent } from './formulario-consumidor.component';

describe('FormularioConsumidorComponent', () => {
  let component: FormularioConsumidorComponent;
  let fixture: ComponentFixture<FormularioConsumidorComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FormularioConsumidorComponent]
    });
    fixture = TestBed.createComponent(FormularioConsumidorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

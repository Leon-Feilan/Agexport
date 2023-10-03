import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormularioTipoColaboradorComponent } from './formulario-tipo-colaborador.component';

describe('FormularioTipoColaboradorComponent', () => {
  let component: FormularioTipoColaboradorComponent;
  let fixture: ComponentFixture<FormularioTipoColaboradorComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FormularioTipoColaboradorComponent]
    });
    fixture = TestBed.createComponent(FormularioTipoColaboradorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

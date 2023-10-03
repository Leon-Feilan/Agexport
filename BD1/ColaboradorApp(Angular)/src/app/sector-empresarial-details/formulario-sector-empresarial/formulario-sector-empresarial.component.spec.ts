import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormularioSectorEmpresarialComponent } from './formulario-sector-empresarial.component';

describe('FormularioSectorEmpresarialComponent', () => {
  let component: FormularioSectorEmpresarialComponent;
  let fixture: ComponentFixture<FormularioSectorEmpresarialComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FormularioSectorEmpresarialComponent]
    });
    fixture = TestBed.createComponent(FormularioSectorEmpresarialComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

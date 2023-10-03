import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SectorEmpresarialDetailsComponent } from './sector-empresarial-details.component';

describe('SectorEmpresarialDetailsComponent', () => {
  let component: SectorEmpresarialDetailsComponent;
  let fixture: ComponentFixture<SectorEmpresarialDetailsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SectorEmpresarialDetailsComponent]
    });
    fixture = TestBed.createComponent(SectorEmpresarialDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

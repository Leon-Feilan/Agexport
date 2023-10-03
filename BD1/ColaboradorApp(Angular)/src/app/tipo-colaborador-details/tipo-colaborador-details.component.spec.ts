import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TipoColaboradorDetailsComponent } from './tipo-colaborador-details.component';

describe('TipoColaboradorDetailsComponent', () => {
  let component: TipoColaboradorDetailsComponent;
  let fixture: ComponentFixture<TipoColaboradorDetailsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TipoColaboradorDetailsComponent]
    });
    fixture = TestBed.createComponent(TipoColaboradorDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

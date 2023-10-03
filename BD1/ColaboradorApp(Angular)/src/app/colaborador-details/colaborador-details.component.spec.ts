import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ColaboradorDetailsComponent } from './colaborador-details.component';

describe('ColaboradorDetailsComponent', () => {
  let component: ColaboradorDetailsComponent;
  let fixture: ComponentFixture<ColaboradorDetailsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ColaboradorDetailsComponent]
    });
    fixture = TestBed.createComponent(ColaboradorDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

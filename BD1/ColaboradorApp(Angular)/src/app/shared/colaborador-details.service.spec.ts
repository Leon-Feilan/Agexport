import { TestBed } from '@angular/core/testing';

import { ColaboradorDetailsService } from './colaborador-details.service';

describe('ColaboradorDetailsService', () => {
  let service: ColaboradorDetailsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ColaboradorDetailsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

import { TestBed } from '@angular/core/testing';

import { SectorEmpresarialDetailsService } from './sector-empresarial-details.service';

describe('SectorEmpresarialDetailsService', () => {
  let service: SectorEmpresarialDetailsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SectorEmpresarialDetailsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

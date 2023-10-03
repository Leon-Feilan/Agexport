import { TestBed } from '@angular/core/testing';

import { FacturaDetailsService } from './factura-details.service';

describe('FacturaDetailsService', () => {
  let service: FacturaDetailsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FacturaDetailsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

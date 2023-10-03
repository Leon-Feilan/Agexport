import { TestBed } from '@angular/core/testing';

import { DetalleDetailsService } from './detalle-details.service';

describe('DetalleDetailsService', () => {
  let service: DetalleDetailsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DetalleDetailsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

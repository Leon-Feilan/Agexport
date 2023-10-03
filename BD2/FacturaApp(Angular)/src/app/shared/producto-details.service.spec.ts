import { TestBed } from '@angular/core/testing';

import { ProductoDetailsService } from './producto-details.service';

describe('ProductoDetailsService', () => {
  let service: ProductoDetailsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ProductoDetailsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

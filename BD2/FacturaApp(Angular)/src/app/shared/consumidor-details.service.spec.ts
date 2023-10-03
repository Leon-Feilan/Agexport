import { TestBed } from '@angular/core/testing';

import { ConsumidorDetailsService } from './consumidor-details.service';

describe('ConsumidorDetailsService', () => {
  let service: ConsumidorDetailsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ConsumidorDetailsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

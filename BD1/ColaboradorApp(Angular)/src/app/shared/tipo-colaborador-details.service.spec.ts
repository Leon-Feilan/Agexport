import { TestBed } from '@angular/core/testing';

import { TipoColaboradorDetailsService } from './tipo-colaborador-details.service';

describe('TipoColaboradorDetailsService', () => {
  let service: TipoColaboradorDetailsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TipoColaboradorDetailsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

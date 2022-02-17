import { TestBed } from '@angular/core/testing';

import { PokedataService } from './pokedata.service';

describe('PokedataService', () => {
  let service: PokedataService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PokedataService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

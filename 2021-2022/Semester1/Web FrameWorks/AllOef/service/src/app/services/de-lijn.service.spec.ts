import { TestBed } from '@angular/core/testing';

import { DeLijnService } from './de-lijn.service';

describe('DeLijnService', () => {
  let service: DeLijnService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DeLijnService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

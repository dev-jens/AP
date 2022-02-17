import { TestBed } from '@angular/core/testing';

import { MyShareServiceService } from './my-share-service.service';

describe('MyShareServiceService', () => {
  let service: MyShareServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MyShareServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

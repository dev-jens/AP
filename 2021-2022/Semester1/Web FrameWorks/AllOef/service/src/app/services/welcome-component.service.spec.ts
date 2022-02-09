import { TestBed } from '@angular/core/testing';

import { WelcomeComponentService } from './welcome-component.service';

describe('WelcomeComponentService', () => {
  let service: WelcomeComponentService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(WelcomeComponentService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

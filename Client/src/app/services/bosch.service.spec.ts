import { TestBed } from '@angular/core/testing';

import { BoschService } from './bosch.service';

describe('BoschService', () => {
  let service: BoschService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(BoschService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

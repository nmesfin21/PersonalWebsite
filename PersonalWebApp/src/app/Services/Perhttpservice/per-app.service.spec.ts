import { TestBed } from '@angular/core/testing';

import { PerAppService } from './per-app.service';

describe('PerAppService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: PerAppService = TestBed.get(PerAppService);
    expect(service).toBeTruthy();
  });
});

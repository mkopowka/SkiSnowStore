import { TestBed } from '@angular/core/testing';

import { ShopRoutingService } from './shop-routing.service';

describe('ShopRoutingService', () => {
  let service: ShopRoutingService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ShopRoutingService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

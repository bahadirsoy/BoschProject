import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IstasyonComponent } from './istasyon.component';

describe('IstasyonComponent', () => {
  let component: IstasyonComponent;
  let fixture: ComponentFixture<IstasyonComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [IstasyonComponent]
    });
    fixture = TestBed.createComponent(IstasyonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

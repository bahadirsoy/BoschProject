import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateSiparisComponent } from './create-siparis.component';

describe('CreateSiparisComponent', () => {
  let component: CreateSiparisComponent;
  let fixture: ComponentFixture<CreateSiparisComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CreateSiparisComponent]
    });
    fixture = TestBed.createComponent(CreateSiparisComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

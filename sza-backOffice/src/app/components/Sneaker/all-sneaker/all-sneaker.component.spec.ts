import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AllSneakerComponent } from './all-sneaker.component';

describe('AllSneakerComponent', () => {
  let component: AllSneakerComponent;
  let fixture: ComponentFixture<AllSneakerComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AllSneakerComponent]
    });
    fixture = TestBed.createComponent(AllSneakerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

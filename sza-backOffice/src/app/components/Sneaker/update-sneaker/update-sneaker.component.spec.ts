import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateSneakerComponent } from './update-sneaker.component';

describe('UpdateSneakerComponent', () => {
  let component: UpdateSneakerComponent;
  let fixture: ComponentFixture<UpdateSneakerComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UpdateSneakerComponent]
    });
    fixture = TestBed.createComponent(UpdateSneakerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

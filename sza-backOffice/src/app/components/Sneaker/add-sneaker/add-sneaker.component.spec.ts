import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddSneakerComponent } from './add-sneaker.component';

describe('AddSneakerComponent', () => {
  let component: AddSneakerComponent;
  let fixture: ComponentFixture<AddSneakerComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AddSneakerComponent]
    });
    fixture = TestBed.createComponent(AddSneakerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

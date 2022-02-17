import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeLijnComponent } from './de-lijn.component';

describe('DeLijnComponent', () => {
  let component: DeLijnComponent;
  let fixture: ComponentFixture<DeLijnComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DeLijnComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DeLijnComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

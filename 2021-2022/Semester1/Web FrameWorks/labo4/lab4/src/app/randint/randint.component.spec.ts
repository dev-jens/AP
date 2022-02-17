import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RandintComponent } from './randint.component';

describe('RandintComponent', () => {
  let component: RandintComponent;
  let fixture: ComponentFixture<RandintComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RandintComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RandintComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

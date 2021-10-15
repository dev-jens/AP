import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RandomScoreComponent } from './random-score.component';

describe('RandomScoreComponent', () => {
  let component: RandomScoreComponent;
  let fixture: ComponentFixture<RandomScoreComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RandomScoreComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RandomScoreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

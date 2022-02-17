import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StartedAgoComponent } from './started-ago.component';

describe('StartedAgoComponent', () => {
  let component: StartedAgoComponent;
  let fixture: ComponentFixture<StartedAgoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StartedAgoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StartedAgoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

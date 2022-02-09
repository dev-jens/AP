import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WelkomComponentComponent } from './welkom-component.component';

describe('WelkomComponentComponent', () => {
  let component: WelkomComponentComponent;
  let fixture: ComponentFixture<WelkomComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WelkomComponentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WelkomComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WelcomeSelectComponentComponent } from './welcome-select-component.component';

describe('WelcomeSelectComponentComponent', () => {
  let component: WelcomeSelectComponentComponent;
  let fixture: ComponentFixture<WelcomeSelectComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WelcomeSelectComponentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WelcomeSelectComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WelkomstcomponentComponent } from './welkomstcomponent.component';

describe('WelkomstcomponentComponent', () => {
  let component: WelkomstcomponentComponent;
  let fixture: ComponentFixture<WelkomstcomponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WelkomstcomponentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WelkomstcomponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

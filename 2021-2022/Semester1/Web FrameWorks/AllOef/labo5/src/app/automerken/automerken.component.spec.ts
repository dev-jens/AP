import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AutomerkenComponent } from './automerken.component';

describe('AutomerkenComponent', () => {
  let component: AutomerkenComponent;
  let fixture: ComponentFixture<AutomerkenComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AutomerkenComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AutomerkenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

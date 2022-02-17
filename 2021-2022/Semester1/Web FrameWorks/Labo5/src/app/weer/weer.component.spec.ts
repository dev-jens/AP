import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WeerComponent } from './weer.component';

describe('WeerComponent', () => {
  let component: WeerComponent;
  let fixture: ComponentFixture<WeerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WeerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WeerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HetWeerComponent } from './het-weer.component';

describe('HetWeerComponent', () => {
  let component: HetWeerComponent;
  let fixture: ComponentFixture<HetWeerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HetWeerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HetWeerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

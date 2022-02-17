import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TekstComponent } from './tekst.component';

describe('TekstComponent', () => {
  let component: TekstComponent;
  let fixture: ComponentFixture<TekstComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TekstComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TekstComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

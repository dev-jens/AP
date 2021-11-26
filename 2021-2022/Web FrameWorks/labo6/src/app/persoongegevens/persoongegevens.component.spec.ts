import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PersoongegevensComponent } from './persoongegevens.component';

describe('PersoongegevensComponent', () => {
  let component: PersoongegevensComponent;
  let fixture: ComponentFixture<PersoongegevensComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PersoongegevensComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PersoongegevensComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

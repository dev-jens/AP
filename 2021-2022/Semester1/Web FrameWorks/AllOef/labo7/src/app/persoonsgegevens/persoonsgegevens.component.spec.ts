import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PersoonsgegevensComponent } from './persoonsgegevens.component';

describe('PersoonsgegevensComponent', () => {
  let component: PersoonsgegevensComponent;
  let fixture: ComponentFixture<PersoonsgegevensComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PersoonsgegevensComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PersoonsgegevensComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

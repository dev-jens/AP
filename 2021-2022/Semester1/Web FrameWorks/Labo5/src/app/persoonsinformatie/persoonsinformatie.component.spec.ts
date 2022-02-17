import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PersoonsinformatieComponent } from './persoonsinformatie.component';

describe('PersoonsinformatieComponent', () => {
  let component: PersoonsinformatieComponent;
  let fixture: ComponentFixture<PersoonsinformatieComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PersoonsinformatieComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PersoonsinformatieComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

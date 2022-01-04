import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RamdomGetalComponent } from './ramdom-getal.component';

describe('RamdomGetalComponent', () => {
  let component: RamdomGetalComponent;
  let fixture: ComponentFixture<RamdomGetalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RamdomGetalComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RamdomGetalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WillekeurigGetalComponent } from './willekeurig-getal.component';

describe('WillekeurigGetalComponent', () => {
  let component: WillekeurigGetalComponent;
  let fixture: ComponentFixture<WillekeurigGetalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WillekeurigGetalComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WillekeurigGetalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MoviePlayerComponent } from './movie-player.component';

describe('MoviePlayerComponent', () => {
  let component: MoviePlayerComponent;
  let fixture: ComponentFixture<MoviePlayerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MoviePlayerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MoviePlayerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

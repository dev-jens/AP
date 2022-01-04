import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TodoLijstComponent } from './todo-lijst.component';

describe('TodoLijstComponent', () => {
  let component: TodoLijstComponent;
  let fixture: ComponentFixture<TodoLijstComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TodoLijstComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TodoLijstComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

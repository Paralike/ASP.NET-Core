import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VendeglatokComponent } from './vendeglatok.component';

describe('VendeglatokComponent', () => {
  let component: VendeglatokComponent;
  let fixture: ComponentFixture<VendeglatokComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VendeglatokComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VendeglatokComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

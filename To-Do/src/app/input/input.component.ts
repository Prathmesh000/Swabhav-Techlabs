import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-input',
  templateUrl: './input.component.html',
  styleUrls: ['./input.component.css']
})
export class InputComponent {
  task: string = '';

  @Output() newTask = new EventEmitter<string>();

  addTask() {
    this.newTask.emit(this.task);
    this.task = ''; 
  }
}

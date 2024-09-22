import { Component, Input, Output, EventEmitter } from '@angular/core';
import { Task } from '../app.component';

@Component({
  selector: 'app-output',
  templateUrl: './output.component.html',
  styleUrls: ['./output.component.css']
})
export class OutputComponent {
  @Input() toDoTasks: Task[] = [];
  @Input() completedTasks: Task[] = [];
  
  @Output() markAsDone = new EventEmitter<number>();
  @Output() deleteTask = new EventEmitter<number>();

  onMarkAsDone(taskId: number) {
    this.markAsDone.emit(taskId);
  }

  onDeleteTask(taskId: number) {
    this.deleteTask.emit(taskId);
  }
}

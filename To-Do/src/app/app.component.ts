import { Component } from '@angular/core';

export interface Task {
  id: number;
  name: string;
  taskCompleted: boolean;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'To-Do-App';

  taskArray: Task[] = [];
  id: number = 1;

  addTaskToList(task: string) {
    if (task) {
      const newTask: Task = { id: this.id++, name: task, taskCompleted: false };
      this.taskArray.push(newTask);
      console.log(this.taskArray);
    }
  }

  completedTask(taskId: number) {
    const task = this.taskArray.find(t => t.id === taskId);
    if (task) {
      task.taskCompleted = true;
    }
  }

  deleteTask(taskId: number) {
    this.taskArray = this.taskArray.filter(t => t.id !== taskId);
    console.log(this.taskArray);
  }

  getToDoTasks() {
    return this.taskArray.filter(t => !t.taskCompleted);
  }

  getCompletedTasks() {
    return this.taskArray.filter(t => t.taskCompleted);
  }
}

import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';

@Component({
	selector: 'app-root',
	standalone: true,
	imports: [CommonModule, RouterOutlet],
	templateUrl: './app.component.html',
	styleUrls: ['./app.component.scss'],
})
export class AppComponent {
	name = 'JP';

	students = [
		{ id: 4, name: 'Stefan', age: 21 },
		{ id: 8,  name: 'Anouk', age: 24 },
		{ id: 15, name: 'Mustafa', age: 20 },
	];

	changeName() {
		this.name += ' Luuk';
	}
}

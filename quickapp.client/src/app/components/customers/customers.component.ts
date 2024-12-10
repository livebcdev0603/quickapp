
import { Component } from '@angular/core';
import { TranslateModule } from '@ngx-translate/core';

import { fadeInOut } from '../../services/animations';
import { TodoDemoComponent } from '../controls/todo-demo.component';

@Component({
    selector: 'app-customers',
    templateUrl: './customers.component.html',
    styleUrl: './customers.component.scss',
    animations: [fadeInOut],
    imports: [TodoDemoComponent, TranslateModule]
})
export class CustomersComponent {

}

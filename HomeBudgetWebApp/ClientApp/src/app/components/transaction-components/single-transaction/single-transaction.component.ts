import { Component, Inject} from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Itransaction } from '../../../interfaces/ITransaction';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
    selector: 'single-transaction',
    templateUrl: './single-transaction.component.html',
    styleUrls: ['./single-transaction.component.scss']
})

export class SingleTransactionComponent {
    transaction: Itransaction;
    constructor(private activatedRoute: ActivatedRoute,
        private router: Router,
        private http: HttpClient,
        @Inject('BASE_URL') private baseUrl: string) {

        this.transaction = <Itransaction>{};
        const id = +this.activatedRoute.snapshot.params['id'];
        console.log('ghghgh', id);
        if (id) {
            console.log('aaaaaa', id);
            const url = this.baseUrl + '/api/Transaction/' + id;
            this.http.get<Itransaction>(url).subscribe(result => {
                this.transaction = result;
                }, error => console.error(error));
        } else {
            console.log('Wrong id - return to home page...');
            this.router.navigate(['home']);
        }
    }
}

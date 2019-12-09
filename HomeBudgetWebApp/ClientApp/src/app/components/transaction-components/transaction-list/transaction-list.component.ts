import { Component, Inject} from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Itransaction } from '../../../interfaces/ITransaction';
import { Router } from '@angular/router';

@Component({
    selector: 'transaction-list',
    templateUrl: './transaction-list.component.html',
    styleUrls: ['./transaction-list.component.scss']
})
export class TransactionListComponent {
    title: string;
    selectedTransaction: Itransaction;
    transactions: Itransaction[];

    constructor(
        http: HttpClient,
        @Inject('BASE_URL') baseUrl: string,
        private router: Router) {
        this.title = 'Ostatnie transakcje';
        const url = baseUrl + 'api/Transaction/Latest/';
        http.get<Itransaction[]>(url).subscribe(result => {
        this.transactions = result;
        console.log(this.transactions);
        }, error => console.error(error));
    }

    onSelect(transaction: Itransaction) {
        console.log('transaction', transaction);
        this.selectedTransaction = transaction;
        console.log('Wybrano quiz o identyfikatorze ' + this.selectedTransaction.Id);
        this.router.navigate(['transaction', this.selectedTransaction.Id]);
    }
}
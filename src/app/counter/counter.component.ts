import { Component } from '@angular/core';
import { Message } from '@angular/compiler/src/i18n/i18n_ast';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
  public soldTickets = 0;
  public NumberOfTickets = 200;
  public reservedTickets = 0;

  public Buy() {
    if (this.NumberOfTickets > 0) {
      this.soldTickets++;
      this.NumberOfTickets--;
    }
  }
  public Reserve() {
    if (this.NumberOfTickets > 0) {
      this.reservedTickets++;
      this.NumberOfTickets--;
    }
  }
  public DeleteReserve() {
    if (this.reservedTickets > 0){
    this.reservedTickets--;
      this.NumberOfTickets++;
    }
  }
  public BuyReserevedTickets() {
    if (this.reservedTickets >0) {
      this.reservedTickets--;
      this.soldTickets++;
    }
  }
}

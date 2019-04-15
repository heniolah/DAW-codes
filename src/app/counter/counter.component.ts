import { Component } from '@angular/core';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
  public soldTickets = 0;
  public NumberOfTickets = 200;
  public reservedTickets = 0;

  public Buy() {
 
    this.soldTickets++;
    this.TicketCounter();
  }
  public TicketCounter() {
    this.NumberOfTickets--;
  }
  public Reserve() {
    this.reservedTickets++;
    this.NumberOfTickets --;
  }
  public DeleteReserve() {
    this.reservedTickets--;
    this.NumberOfTickets++;
  }
  public BuyReserevedTickets() {
    this.reservedTickets--;
    this.NumberOfTickets--;
  }
}



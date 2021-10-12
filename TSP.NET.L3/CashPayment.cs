using System;

namespace TSP.NET.L3
{
    public class CashPayment : IPayment
    {
        private int _cashAccepted;

        public void Pay(TicketDetails ticket, Action onPayChangeToMobilePhone = null)
        {
            AcceptCash(ticket);
            DispenseChange(ticket, onPayChangeToMobilePhone);
        }
        private void AcceptCash(TicketDetails ticket)
        {
            var r = new Random();
            _cashAccepted = r.Next((int) ticket.Price, (int) ticket.Price + 1000);
        }
        private void DispenseChange(TicketDetails ticket, Action onPayChangeToMobilePhone)
        {
            if (_cashAccepted > ticket.Price &&
                !TryToDispense(_cashAccepted - ticket.Price))
                onPayChangeToMobilePhone?.Invoke();
        }
        private bool TryToDispense(decimal changeAmount)
        {
            Random gen = new Random();
            return gen.Next(1) == 0;
        }
    }
}
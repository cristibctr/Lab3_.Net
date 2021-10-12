using System;

namespace TSP.NET.L3
{

    public class PaymentModel
    {
        public void BuyTicket(TicketDetails ticket, IPayment payment, Action onPayChangeToMobilePhone = null)
        {
            payment.Pay(ticket, onPayChangeToMobilePhone);
        }
    }
}

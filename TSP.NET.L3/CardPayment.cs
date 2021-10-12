using System;

namespace TSP.NET.L3
{
    public class CardPayment : IPayment
    {
        public void Pay(TicketDetails ticket, Action onPayChangeToMobilePhone = null)
        {
            var gateway = new ProcessingCenterGateway();
            gateway.Charge(ticket.Price);
        }
    }
}
using System;

namespace TSP.NET.L3
{
    public interface IPayment
    {
        public void Pay(TicketDetails ticket, Action onPayChangeToMobilePhone = null);
    }
}
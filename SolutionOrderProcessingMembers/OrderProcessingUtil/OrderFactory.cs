using OrderProcessingMembersBL.Domein;
using OrderProcessingMembersBL.Domein.Strategies; 
using OrderProcessingMembersBL.Interfaces;

namespace OrderProcessingUtil
{
    public class OrderFactory
    {
        
        public Order CreateOrder(int id, Lid lid, Event @event, int ticketAmount)
        {
            IPriceCalculator priceCalculator;
            IDeliveryMethod deliveryMethod;
            IExtraServices extraServices;

        
            if (lid.Status == "Bronze")
            {
                priceCalculator = new BronzePriceCalculator();
                deliveryMethod = new StandardDelivery();
                extraServices = new BronzeServices();
            }
            else if (lid.Status == "Silver")
            {
                priceCalculator = new SilverPriceCalculator();
                deliveryMethod = new ExpressDelivery();
                extraServices = new SilverServices();
            }
            else if (lid.Status == "Gold")
            {
                priceCalculator = new GoldPriceCalculator();
                deliveryMethod = new ExpressDelivery();
                extraServices = new GoldServices();
            }
            else 
            {
                priceCalculator = new StandardPriceCalculator();
                deliveryMethod = new StandardDelivery();
                extraServices = new StandardServices();
            }

            Order newOrder = new Order(id, lid, @event, ticketAmount, priceCalculator, deliveryMethod, extraServices);
            return newOrder;
        }
    }
}
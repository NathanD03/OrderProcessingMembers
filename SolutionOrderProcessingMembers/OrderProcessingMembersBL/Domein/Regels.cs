using OrderProcessingMembersBL.Interfaces;
using System.Collections.Generic;

namespace OrderProcessingMembersBL.Domein.Strategies
{
    // --- PRICING ---
    public class StandardPriceCalculator : IPriceCalculator
    {
        public double CalculateTotal(double basePrice)
        {
            return basePrice;
        }
    }

    public class BronzePriceCalculator : IPriceCalculator
    {
        public double CalculateTotal(double basePrice)
        {
            return basePrice + 100.00;
        }
    }

    public class SilverPriceCalculator : IPriceCalculator
    {
        public double CalculateTotal(double basePrice)
        {
            return basePrice * 2.0;
        }
    }

    public class GoldPriceCalculator : IPriceCalculator
    {
        public double CalculateTotal(double basePrice)
        {
            return basePrice * 3.0;
        }
    }

    // --- DELIVERY ---
    public class StandardDelivery : IDeliveryMethod
    {
        public string GetDeliveryType()
        {
            return "Standard delivery";
        }
    }

    public class ExpressDelivery : IDeliveryMethod
    {
        public string GetDeliveryType()
        {
           
            return "Express delivery (including welcome package)";
        }
    }

    // --- SERVICES ---
    public class StandardServices : IExtraServices
    {
        public List<string> GetServices()
        {
            // Lege lijst voor standard leden
            List<string> services = new List<string>();
            return services;
        }
    }

    public class BronzeServices : IExtraServices
    {
        public List<string> GetServices()
        {
            List<string> services = new List<string>();
            services.Add("Name tag"); 
            return services;
        }
    }

    public class SilverServices : IExtraServices
    {
        public List<string> GetServices()
        {
            List<string> services = new List<string>();
            services.Add("Name tag"); 
            services.Add("Dinner"); 
            return services;
        }
    }

    public class GoldServices : IExtraServices
    {
        public List<string> GetServices()
        {
            List<string> services = new List<string>();
            services.Add("Nametag"); 
            services.Add("Dinner"); 
            services.Add("Pickup service"); 
            return services;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace OOP3
{
    public class ExpressShipment : Shipment
    {
        private double _extraFee;
        public double ExtraFee
        {
            get { return _extraFee; }
            set
            {
                if (value >= 0)
                    _extraFee = value;
            }
        }
        public ExpressShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination, double _extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = _extraFee;
        }

        public override double EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + ExtraFee; }
        }
        public override void PrintShipment()
        {
            Console.WriteLine("\nExpress Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description : {Description}");
            Console.WriteLine($"Weight : {Weight} KG");
            Console.WriteLine($"Delivery Fee : {DeliveryFee} EGP");
            Console.WriteLine($"Extra Fee : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }
}
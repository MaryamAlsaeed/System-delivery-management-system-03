using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class PriorityInternationalShipment : InternashionalShipment
    {
        private double _priorityFee;
        public double PriorityFee
        {
            get
            {
                return _priorityFee;
            }
            set
            {
                if (value >= 0)
                    _priorityFee = value;
            }
        }
        public PriorityInternationalShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination, string destinationCountry, double customsFee, double priorityFee)
            : base(trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee)
        {
            PriorityFee = priorityFee;
        }
        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine($"\n*** PRIORITY CUSTOMS REPORT ***");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Destination: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee} EGP");
            Console.WriteLine($"Priority Fee: {PriorityFee} EGP");
        }
        public override void PrintShipment()
        {
            Console.WriteLine("\nPriority International Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description : {Description}");
            Console.WriteLine($"Weight : {Weight} KG");
            Console.WriteLine($"Delivery Fee : {DeliveryFee} EGP");
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Customs Fee : {CustomsFee} EGP");
            Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP");
        }
    }
}

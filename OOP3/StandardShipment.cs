using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OOP3
{
    internal class StandardShipment : Shipment
    {
        public override void PrintShipment() 
        {
            Console.WriteLine($"Tracking code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }
        public StandardShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination) 
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
    }
}

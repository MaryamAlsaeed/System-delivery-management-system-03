using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class DeliveryCenter
    {
        private Shipment[] shipments;
        private string _driverName;
        public string DriverName
        {
            get { return _driverName; }
            set { _driverName = value; }
        }

        public DeliveryCenter()
        {
            shipments = new Shipment[10];
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                    return shipments[index];

                return default;
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }
        }
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                        return shipments[i];
                }
                return default;
            }
        }
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }
        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }
            return false;
        }
        public void PrintAllShipments()
        {
            Console.WriteLine("\n==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");
            Console.WriteLine($"Driver : {DriverName}");

            foreach (Shipment s in shipments)
            {
                if (s != null)
                {
                    s.PrintShipment();
                }
            }
            Console.WriteLine("==========================================");
        }

    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class DeliveryAddress
    {
        public string city;
        public string street;
        public int BuildingNumber;
        public DeliveryAddress(string city, string street, int BuildingNumber)
        {
            this.city = city;
            this.street = street;
            this.BuildingNumber = BuildingNumber;
        }
        public string GetFullAddress()
        {
            return $"City: {city}, Street: {street}, Building Number: {BuildingNumber}";
        }
    }
}

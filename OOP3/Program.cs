namespace OOP3
{
    internal class Program
    {
        #region Theoretical Questions
        //-----------------Q1:-----------------
        //
        // a) What is the difference between Method Overloading and Method Overriding?
        // Method oveloading:
        // means same method with: Different number of parameters - Different datatypes - Arrangement of params differ.
        // called by static binding >> refers to refernce >> early binding
        //
        // Method overriding:
        // Method overriding is related to inheritance while child can implement its own function inherited from the parent.
        // it has the same name method and number of params.
        // called by dynamic binding >> refers to object it self >> late binding
        //
        // b) What is the difference between Static Binding and Dynamic Binding? 
        // Static binding:
        // The method is executed at compile time.
        // It refers to the reference (variable)
        // Also called by (Early binding)
        //
        // Dynamic binding:
        // THe method is executed at runtime
        // It refers to the object it self
        // Also called by (Late binding)
        //
        //-----------------Q2:-----------------
        //
        // a) What is the purpose of the sealed keyword when applied to a class?
        // Sealed keyword prevents any other class to inherit from any other class.
        //
        // b) What is the difference between a sealed class and a sealed method? 
        // Sealed class: 
        // It is applied to the entire class.
        // No class can inherit from it.
        //
        // Sealed method: 
        // It is applied to a single method.
        // Derrived classes cannot override this method.
        //
        // c) Can a sealed method be overridden? Why? 
        // no, because sealed method doesn't allow to be overriden.
        // => the keyword (sealed) acts as locked method.
        //
        #endregion

        static void Main(string[] args)
        {
            string driverName = "Ahmed Mohamed";

            DeliveryCenter center = new DeliveryCenter();
            center.DriverName = driverName;

            Console.WriteLine($"Driver created: {driverName}");
            Console.WriteLine($"DeliveryCenter created\n");

            DeliveryAddress addr1 = new DeliveryAddress("Cairo", "Nasr City", 42);
            StandardShipment standard = new StandardShipment("ord01", "Laptop", 3, 80, addr1);

            DeliveryAddress addr2 = new DeliveryAddress("Alexandria", "Smouha", 15);
            ExpressShipment express = new ExpressShipment("ord02", "Mobile Phone", 2, 60, addr2, 30);

            DeliveryAddress addr3 = new DeliveryAddress("Cairo", "Heliopolis", 88);
            InternashionalShipment international = new InternashionalShipment("ord02", "Television", 8, 120, addr3, "Germany", 100);

            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            center.PrintAllShipments();

            DeliveryHelper.PrintShipmentDetails(standard);
            DeliveryHelper.PrintShipmentDetails(express);
            DeliveryHelper.PrintShipmentDetails(international);

            Console.WriteLine();

            Console.WriteLine("Updating weight..");

            Console.WriteLine($"Original Weight : {standard.Weight} KG");
            standard.UpdateWeight(5);
            Console.WriteLine($"Updated Weight : {standard.Weight} KG");
            standard.UpdateWeight(5, 0.5);
            Console.WriteLine($"Updated Weight After Packing : {standard.Weight} KG");
            Console.WriteLine("==========================================");

            Shipment[] mixedShipments = new Shipment[]
            {
            new StandardShipment("MIX001", "Books", 1.5, 50, new DeliveryAddress("Cairo", "Maadi", 10)),
            new ExpressShipment("MIX002", "Medicine", 0.5, 70, new DeliveryAddress("Cairo", "Zamalek", 20), 25),
            new InternashionalShipment("MIX003", "Electronics", 3, 100, new DeliveryAddress("Cairo", "New Cairo", 30), "USA", 150)
            };

            /*
             * Sealed class: - it is applied to the entire class
             *               - no class can inherit from it
             *
             * Sealed method: - it is applied to a single method
             *                - derived classes cannot override this method
             */
        }
    }
}

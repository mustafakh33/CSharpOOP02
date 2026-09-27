using CSharpOOP01;
using CSharpOOP02.@class;

namespace CSharpOOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions
            #region Question 1
            // a) What is the difference between a class and a struct?
            // Answer: A class is a reference type, while a struct is a value type. Classes support inheritance and polymorphism, while structs do not. Structs are typically used for small data structures that do not require inheritance or complex behavior.

            // b) Why are classes more suitable than structs for large applications?
            // Answer: Classes are more suitable for large applications because they support inheritance, polymorphism, and encapsulation, which allow for better code organization and reuse. Additionally, classes can have constructors, destructors, and finalizers, which provide more control over object lifecycle management. Structs, being value types, are copied on assignment and can lead to performance issues when used in large applications.

            #endregion

            #region Question 2
            /*
             Consider the following code:
            public class Shipment
            {
               public string TrackingCode { get; set; }
            }

            public class ExpressShipment : Shipment
             { 
               public decimal ExtraFee { get; set; }
              }
             */
            // a) Which class is the parent class?
            // Answer: The parent class is Shipment.
            // b) Which class is the child class?
            // Answer: The child class is ExpressShipment.
            // c) What members are inherited by ExpressShipment?
            // Answer: ExpressShipment inherits the TrackingCode property from the Shipment class.
            // d) Why is inheritance better than duplicating the same code in multiple classes?
            // Answer: Inheritance promotes code reuse and reduces redundancy, making the codebase easier to maintain and extend. It allows for a hierarchical relationship between classes, enabling polymorphism and encapsulation, which leads to cleaner and more organized code.

            #endregion
            #endregion

            #region Part 02 : Practical
            // Smart Delivery Management System
            /*
             Build a Console Application that performs the following:
                1. Create a DeliveryCenter.
                2. Read the center name from the user.
                3. Create one StandardShipment.
                4. Create one ExpressShipment.
                5. Create one InternationalShipment.
                6. Read all shipment data from the user.
                7. Add the shipments to the delivery center.
                8. Print all shipments.
                9. Search for a shipment using the existing tracking code indexer.
                10. Remove one shipment using its tracking code.
                11. Print the remaining shipments.
             */
            // Step 1: Create a DeliveryCenter
            Console.Write("Enter Delivery Center Name: ");
            string centerName = Console.ReadLine()!;
            DeliveryCenter center = new DeliveryCenter(centerName);

            // Step 3: Create one StandardShipment
            Console.WriteLine();
            Console.WriteLine("Enter Standard Shipment Data");

            Console.Write("Tracking Code: ");
            string standardTrackingCode = Console.ReadLine()!;

            Console.Write("Description: ");
            string standardDescription = Console.ReadLine()!;

            Console.Write("Weight: ");
            decimal standardWeight = decimal.Parse(Console.ReadLine()!);

            Console.Write("Delivery Fee: ");
            decimal standardDeliveryFee = decimal.Parse(Console.ReadLine()!);

            DeliveryAddress standardAddress = ReadAddress();

            StandardShipment standardShipment = new StandardShipment(standardTrackingCode, standardDescription, standardWeight, standardDeliveryFee, standardAddress);

            // Step 4: Create one ExpressShipment
            Console.WriteLine();
            Console.WriteLine("Enter Express Shipment Data");

            Console.Write("Tracking Code: ");
            string expressTrackingCode = Console.ReadLine()!;

            Console.Write("Description: ");
            string expressDescription = Console.ReadLine()!;

            Console.Write("Weight: ");
            decimal expressWeight = decimal.Parse(Console.ReadLine()!);

            Console.Write("Delivery Fee: ");
            decimal expressDeliveryFee = decimal.Parse(Console.ReadLine()!);

            DeliveryAddress expressAddress = ReadAddress();

            Console.Write("Extra Fee: ");
            decimal extraFee = decimal.Parse(Console.ReadLine()!);

            ExpressShipment expressShipment = new ExpressShipment(
                expressTrackingCode,
                expressDescription,
                expressWeight,
                expressDeliveryFee,
                expressAddress,
                extraFee
            );

            // Step 5: Create one InternationalShipment
            Console.WriteLine();
            Console.WriteLine("Enter International Shipment Data");

            Console.Write("Tracking Code: ");
            string internationalTrackingCode = Console.ReadLine()!;

            Console.Write("Description: ");
            string internationalDescription = Console.ReadLine()!;

            Console.Write("Weight: ");
            decimal internationalWeight = decimal.Parse(Console.ReadLine()!);

            Console.Write("Delivery Fee: ");
            decimal internationalDeliveryFee = decimal.Parse(Console.ReadLine()!);

            DeliveryAddress internationalAddress = ReadAddress();

            Console.Write("Destination Country: ");
            string destinationCountry = Console.ReadLine()!;

            Console.Write("Customs Fee: ");
            decimal customsFee = decimal.Parse(Console.ReadLine()!);


            InternationalShipment internationalShipment =
                new InternationalShipment(
                    internationalTrackingCode,
                    internationalDescription,
                    internationalWeight,
                    internationalDeliveryFee,
                    internationalAddress,
                    destinationCountry,
                    customsFee
                );


            // Step 6: Add the shipments to the delivery center
            // Step 2: Read the center name from the user
            Console.WriteLine("=========================================");
            Console.WriteLine($"Delivery Center : '{center.CenterName}'");
            Console.WriteLine("=========================================");
            Console.WriteLine();

            if (center.AddShipment(standardShipment))
            {
                Console.WriteLine("Shipment Added Successfully.");
            }

            if (center.AddShipment(expressShipment))
            {
                Console.WriteLine("Shipment Added Successfully.");
            }

            if (center.AddShipment(internationalShipment))
            {
                Console.WriteLine("Shipment Added Successfully.");
            }

            // Step 7: Print all shipments
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine($"Delivery Center : {center.CenterName}");
            Console.WriteLine("==========================================");

            Console.WriteLine();
            Console.WriteLine("Standard Shipment");
            Console.WriteLine("------------------------------------------");

            standardShipment.PrintShipment();


            Console.WriteLine();
            Console.WriteLine("Express Shipment");
            Console.WriteLine("------------------------------------------");

            expressShipment.PrintShipment();

            Console.WriteLine();
            Console.WriteLine("International Shipment");
            Console.WriteLine("------------------------------------------");

            internationalShipment.PrintShipment();


            // Step 8: Search for a shipment using the existing tracking code indexer

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Search Shipment");
            Console.WriteLine("==========================================");

            Console.Write("Enter Tracking Code to Search: ");
            string searchCode = Console.ReadLine()!;

            Shipment? foundShipment = center[searchCode];

            if (foundShipment != null)
            {
                Console.WriteLine();
                Console.WriteLine("Shipment Found Successfully.");
                Console.WriteLine();

                foundShipment.PrintShipment();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Shipment Not Found.");
            }

            // Step 9: Remove one shipment using its tracking code
            Console.WriteLine();
            Console.Write("Enter Tracking Code to Remove: ");
            string removeCode = Console.ReadLine()!;

            bool removed = center.RemoveShipment(removeCode);

            if (removed)
            {
                Console.WriteLine();
                Console.WriteLine("Shipment Removed Successfully.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Shipment Not Found.");
            }

            // Step 10: Print the remaining shipments
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Remaining Shipments");
            Console.WriteLine("==========================================");

            center.PrintAllShipments();


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();


            #endregion
        }
        // Read Delivery Address
        static DeliveryAddress ReadAddress()
        {
            Console.Write("City: ");
            string city = Console.ReadLine()!;

            Console.Write("Street: ");
            string street = Console.ReadLine()!;

            Console.Write("Building Number: ");
            int buildingNumber = int.Parse(Console.ReadLine()!);

            return new DeliveryAddress(
                city,
                street,
                buildingNumber
            );
        }
    }
}

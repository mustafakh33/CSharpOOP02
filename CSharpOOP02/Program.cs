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
        }
    }
}

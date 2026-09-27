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
            #endregion
        }
    }
}

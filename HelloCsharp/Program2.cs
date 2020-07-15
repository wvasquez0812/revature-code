using System;

namespace HelloCsharp
{
    class Program2
    {
        static void Main()
        {
            Console.Write("Enter first name: ");
            var firstName = Console.ReadLine();  //lazy datatype given based on content

            Console.Write("Enter lastname: ");
            string lastName = Console.ReadLine(); // eager datatype explicit 

            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine("{0} {1}", firstName, lastName); //place holders
            Console.WriteLine($"{firstName} {lastName}");
            

            Console.ReadLine();
        }
    }
}
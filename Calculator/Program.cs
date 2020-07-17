using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Basic Calculator");
            var stay = true;

            do
            {
                Console.WriteLine("Menue");
                System.Console.WriteLine("Press 1 for Addition");
                System.Console.WriteLine("Press 2 for Subtraction");
                System.Console.WriteLine("Press 3 for Multiplication");
                System.Console.WriteLine("Press 4 for Division");
                System.Console.WriteLine("Press 5 for Exit");

                System.Console.Write("Choice: ");
                var choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        // var input1 = (double) Console.ReadLine(); //explicit casting with exception
                        // var input2 = Console.ReadLine() as double; // explicit casting with null

                        var input1 = double.Parse(Console.ReadLine()); //explicit parsing with exception
                        double input2;
                        double.TryParse(Console.ReadLine(), out input2); //explicit parsing with 0
                        
                        Add(input1, input2);
                        break;

                    case "2":
                        double input3;
                        double input4;

                        if(double.TryParse(System.Console.ReadLine(), out input3))
                        {
                            System.Console.WriteLine("valid");
                        }
                        else
                        {
                            System.Console.WriteLine("invalid");
                        }

                        if(double.TryParse(System.Console.ReadLine(), out input4))
                        {
                            System.Console.WriteLine("valid");
                        }
                        else
                        {
                            System.Console.WriteLine("invalid");
                        }
                    
                    
                        Substract(input3, input4);
                        break;

                    case "3":
                        double input5;
                        double input6;

                        if(double.TryParse(Console.ReadLine(), out input5))
                        {

                            System.Console.WriteLine("valid input");

                            if(double.TryParse(Console.ReadLine(), out input6))
                            {
                                System.Console.WriteLine("valid");
                                Multiply(input5, input6);
                            }
                            else
                            {
                                System.Console.WriteLine("invalid");
                            }
                        } 
                        else
                        {
                            System.Console.WriteLine("invalid");
                        }
                        break;

                    default:
                        stay = false;
                        break;
                }
                System.Console.WriteLine("");
            }
            while(stay);


        }

        /*
            casting - tries to convert
            "2a" -> error

            parsing - searches for matching type
            "2a" -> 2.0 
        */

        static void Add(double operand1, double operand2){
            var result =  operand1 + operand2;
            System.Console.WriteLine($"your answer is: {result}");
        }

        static void Substract(double operand1, double operand2){
            var result =  operand1 - operand2;
            System.Console.WriteLine($"your answer is: {result}");
        }

        static void Multiply(double input5, double input6)
        {
            double result = input5 * input6;
            System.Console.WriteLine($"your answer is: {result}");
        }
        static void Divide()
        {
            
        }
    }
}

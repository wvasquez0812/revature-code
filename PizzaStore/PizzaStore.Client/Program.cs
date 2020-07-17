using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
    class Program
    {
        static void Main()
        {
           Welcome();
        }

        static void Welcome()
        {
            System.Console.WriteLine("Welcome to PizzaWorld");
            System.Console.WriteLine("Best Pizza in the World");
            System.Console.WriteLine();
            
            //array
            //1-dimensional array
            string[] cart1 = {"","",""}; // initial values
            string[] cart2 = new string[3]; // default values
            string[] cart3 = new string[]{"", "", ""}; //initial values - custom datatyoe or earlier C# versions

            //list 
            List<string> cart4 = new List<string>{"", "", ""}; // initial
            List<Pizza> cart5 = new List<Pizza>(); // default

            //Menu(cart2);
            //Menu2(cart5);

            var startup = new PizzaStore.Client.Startup();
            var user =  new User();
            var store = new Store();
            //var order  = startup.CreateOrder(user, store);
            // if (order != null)
            // {
            //     Menu3(order);
            // }
            // else
            // {
            //     System.Console.WriteLine("technical difficulties, we'll be back!");
            // }

            try
            {
                Menu3(startup.CreateOrder(user, store));
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        // static void Menu(string[] cart)
        // {
        //     var exit = false;
        //     var number = 0;

        //     do
        //     {
        //         if(number < cart.Length)
        //         {
        //             System.Console.WriteLine("Select 1 Cheese Pizza");
        //             System.Console.WriteLine("Select 2 Pepperoni Pizza");
        //             System.Console.WriteLine("Select 3 Hawaiian Pizza");
        //             System.Console.WriteLine("Select 4 Custom Pizza");
        //             System.Console.WriteLine("Select 5 Display Cart");
        //             System.Console.WriteLine("Select 6 Exit Pizza");
        //             System.Console.WriteLine();

        //             int select;
        //             int.TryParse(Console.ReadLine(), out select);

        //             switch(select)
        //             {
        //                 case 1:
        //                     cart[number] = "cheese";
        //                     number += 1;
        //                     System.Console.WriteLine("added Cheese");
        //                     break;

        //                 case 2:
        //                     cart[number] = "pepperoni";
        //                     number += 1;
        //                     System.Console.WriteLine("added Pepperoni");
        //                     break;

        //                 case 3:
        //                     cart[number] = "pineapple";
        //                     number += 1;
        //                     System.Console.WriteLine("added Pineapple");
        //                     break;

        //                 case 4:
        //                     cart[number] = "custom";
        //                     number += 1;
        //                     System.Console.WriteLine("added Custom");
        //                     break;
        //                 case 5:
        //                     DisplayCart(cart);
        //                     break;
        //                 case 6:
        //                     exit = true;
        //                     break;
        //             }
        //         }
        //         else
        //         {
        //             DisplayCart(cart);
        //             exit = true;
        //         }
        //         System.Console.WriteLine();

        //     } while(!exit);
        // }
        // static void Menu2(List<Pizza> cart)
        // {
        //     var exit = false;
        //     var number = 0;
        //     var startup = new PizzaStore.Client.Startup();

        //     do
        //     {

        //             System.Console.WriteLine("Select 1 Cheese Pizza");
        //             System.Console.WriteLine("Select 2 Pepperoni Pizza");
        //             System.Console.WriteLine("Select 3 Hawaiian Pizza");
        //             System.Console.WriteLine("Select 4 Custom Pizza");
        //             System.Console.WriteLine("Select 5 Display Cart");
        //             System.Console.WriteLine("Select 6 Exit Pizza");
        //             System.Console.WriteLine();

        //             int select;
        //             int.TryParse(Console.ReadLine(), out select);

        //             switch(select)
        //             {
        //                 case 1:
                            
        //                     cart.Add(startup.CreatePizza("L", "Stuffed", new List<string>{"cheese"}));
        //                     number += 1;
        //                     System.Console.WriteLine("added Cheese");
        //                     break;

        //                 case 2:
                            
        //                     cart.Add(startup.CreatePizza("L", "Stuffed", new List<string>{"pepperoni"}));
        //                     number += 1;
        //                     System.Console.WriteLine("added Pepperoni");
        //                     break;

        //                 case 3:
                            
        //                     cart.Add(startup.CreatePizza("L", "Stuffed", new List<string>{"pineapple"}));
        //                     number += 1;
        //                     System.Console.WriteLine("added Pineapple");
        //                     break;

        //                 case 4:
        //                     cart.Add(startup.CreatePizza("L", "Stuffed", new List<string>{"custom"}));
        //                     number += 1;
        //                     System.Console.WriteLine("added Custom");
        //                     break;
        //                 case 5:
        //                     DisplayCart2(cart);
        //                     break;
        //                 case 6:
        //                     exit = true;
        //                     break;
        //             }
                

        //         System.Console.WriteLine();

        //     } while(!exit);
        // }

        static void Menu3(Order cart)
        {
             var exit = false;
            var startup = new PizzaStore.Client.Startup();

            do
            {

                    System.Console.WriteLine("Select 1 Cheese Pizza");
                    System.Console.WriteLine("Select 2 Pepperoni Pizza");
                    System.Console.WriteLine("Select 3 Hawaiian Pizza");
                    System.Console.WriteLine("Select 4 Custom Pizza");
                    System.Console.WriteLine("Select 5 Display Cart");
                    System.Console.WriteLine("Select 6 Exit Pizza");
                    System.Console.WriteLine();

                    int select;
                    int.TryParse(Console.ReadLine(), out select);

                    switch(select)
                    {
                        case 1:
                            
                            cart.CreatePizza("L", "Stuffed", new List<string>{"cheese"});
                            System.Console.WriteLine("added Cheese");
                            break;

                        case 2:
                            
                            cart.CreatePizza("L", "Stuffed", new List<string>{"pepperoni"}); 
                            System.Console.WriteLine("added Pepperoni");
                            break;

                        case 3:
                            
                            cart.CreatePizza("L", "Stuffed", new List<string>{"pineapple"});
                            System.Console.WriteLine("added Pineapple");
                            break;

                        case 4:
                            cart.CreatePizza("L", "Stuffed", new List<string>{"custom"});
                            System.Console.WriteLine("added Custom");
                            break;
                        case 5:
                            DisplayCart3(cart);
                            break;
                        case 6:
                            exit = true;
                            break;
                    }
                

                System.Console.WriteLine();

            } while(!exit);
        }
        static void DisplayCart (string[] cart)
        {
            System.Console.WriteLine("Your Cart:");
            foreach(var pizza in cart)
            {
                System.Console.WriteLine(pizza);
            }
            // for(var i =0 ; i < cart.Length -1; i += 1)
            // {
            //     System.Console.WriteLine(cart[i]);
            // }
        }

        static void DisplayCart2 (List<Pizza> cart)
        {
            System.Console.WriteLine("Your Cart:");
           
            foreach(var pizza in cart)
            {
                System.Console.WriteLine(pizza.ToString());
            }
            // for(var i =0 ; i < cart.Length -1; i += 1)
            // {
            //     System.Console.WriteLine(cart[i]);
            // }
        }

        static void DisplayCart3(Order cart)
        {
             foreach(var pizza in cart.Pizzas)
            {
                System.Console.WriteLine(pizza.ToString());
            }
        }
    }
}

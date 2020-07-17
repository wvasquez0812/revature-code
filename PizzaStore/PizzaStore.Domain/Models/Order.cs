using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class Order
    {
        public List<Pizza> Pizzas {get; set;}

         public void CreatePizza(string size, string crust, List<string> toppings)
        {
            var pizza = new Pizza(size, crust, toppings);

            // pizza.Size = size;
            // pizza.Crust = crust;
            // pizza.Toppings.AddRange(toppings);
            
            Pizzas.Add(pizza);
        }

        public Order()
        {
            Pizzas = new List<Pizza>();
        }
    }
}
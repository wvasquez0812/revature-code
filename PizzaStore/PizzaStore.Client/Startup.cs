using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
    internal class Startup
    {
       public Order CreateOrder(User user, Store store)
       {
           try
           {
               var order = new Order();

                user.Orders.Add(order);
                store.Orders.Add(order);

                return order;
           }
           catch
           {    
               throw new System.Exception("we messed up");
               //return null;
           }
       }
    }
}
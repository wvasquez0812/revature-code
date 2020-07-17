using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Pizza
    {
        //STATE
        //feilds -- every instance has copy, or shares copy. should be priv
        string ImageUrl = "";
        double Diameter = 0;
        
        public List<string> _toppings = new List<string>();
        public string Crust {get;}

        //properties -- should be pub
        public string Size { get; } // members class can change, no set only accessible by constructor


        //BEHAVIORS
        //methods
        void AddToppings(string topping)
        {
            _toppings.Add(topping);
        }

        public override string ToString()
        {
            // string concatenation. strings are immutable
            /*
            top1
            top1 + top2
            etc
            */

            //stringbuilder mutable. more memory efficient
            /*
            top1 + top2 + top3
            */
            var sb = new StringBuilder();
            foreach(var t in _toppings)
            {
                sb.Append(t);
            }
            return $"{Crust}\n{Size}\n{sb}";
        }
        //constructors
        public Pizza(string size, string crust, List<string> toppings)
        {
            Size = size;
            Crust = crust;
            _toppings.AddRange(toppings);
        }
        //finalizers or destructors

    }
}
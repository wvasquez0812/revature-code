using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Pizza
    {
        //STATE
        //feilds -- every instance has copy, or shares copy. should be priv
        private readonly string ImageUrl = "";
        private const double Diameter = 0;
        
        private static string _name = "pizza";
        private List<string> _toppings = new List<string>();
        public string Crust {get; set;}

        //properties -- should be pub
        public string Size { get; set;} // members class can change, no set only accessible by constructor

        public List<string> Toppings
        {get
            {
                return _toppings;
            }
        }
        
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

        public Pizza()
        {
            // empty intentionally
            Size = "";
            Crust = "";
        }
        //finalizers or destructors

    }
}
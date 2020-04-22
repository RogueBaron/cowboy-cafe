using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Menu
    {
        public static IEnumerable<Entree> Entrees()
        {
            List<Entree> entrees = new List<Entree>();
            entrees.Add(new AngryChicken());
            entrees.Add(new CowpokeChili());
            entrees.Add(new DakotaDoubleBurger());
            entrees.Add(new PecosPulledPork());
            entrees.Add(new RustlersRibs());
            entrees.Add(new TexasTripleBurger());
            entrees.Add(new TrailBurger());

            IEnumerable<Entree> en = entrees;
            return en;
        }

        public static IEnumerable<Side> Sides()
        {
            List<Side> sides = new List<Side>();
            sides.Add(new BakedBeans());
            sides.Add(new ChiliCheeseFries());
            sides.Add(new CornDodgers());
            sides.Add(new PanDeCampo());

            IEnumerable<Side> sd = sides;
            return sd;
        }

        public static IEnumerable<Drink> Drinks()
        {
            List<Drink> drinks = new List<Drink>();
            drinks.Add(new CowboyCoffee());
            drinks.Add(new JerkedSoda());
            drinks.Add(new TexasTea());
            drinks.Add(new Water());

            IEnumerable<Drink> dr = drinks;
            return dr;
        }

        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> items = new List<IOrderItem>();
            foreach (Entree e in Menu.Entrees())
            {
                items.Add(e);
            }
            foreach (Side s in Menu.Sides())
            {
                items.Add(s);
            }
            foreach (Drink d in Menu.Drinks())
            {
                items.Add(d);
            }
            IEnumerable<IOrderItem> i = items;
            return i;
        }

        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, String s)
        {
            if (s == null)
            {
                return items;
            }

            List<IOrderItem> results = new List<IOrderItem>();

            foreach (IOrderItem i in items)
            {
                if (i.ToString().Contains(s, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(i);
                }
            }
            return results;
        }

        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> s)
        {
            if (s == null || items == null)
            {
                return items;
            }

            List<IOrderItem> results = new List<IOrderItem>();

            foreach (IOrderItem i in items)
            {
                foreach(String str in s)
                {
                    if (i.GetType().Equals(s))
                    {
                        results.Add(i);
                    }
                }
            }
            return results;
        }

        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem i in items)
                {
                    if (i.Calories <= max) results.Add(i);
                }
                return results;
            }

            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem i in items)
                {
                    if (i.Calories >= min) results.Add(i);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem i in items)
            {
                if (i.Calories >= min && i.Calories <= max)
                {
                    results.Add(i);
                }
            }
            return results;
        }

        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem i in items)
                {
                    if (i.Price <= max) results.Add(i);
                }
                return results;
            }

            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem i in items)
                {
                    if (i.Price >= min) results.Add(i);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem i in items)
            {
                if (i.Price >= min && i.Price <= max)
                {
                    results.Add(i);
                }
            }
            return results;
        }

    }
}

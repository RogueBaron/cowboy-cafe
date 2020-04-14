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
    }
}

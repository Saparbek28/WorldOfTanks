using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfTAnks
{
    public class tank
    {
        protected string Name;
        protected int Ammunition;
        protected int LvlArmor;
        protected int LvlManeuver;
        public tank(int Ammunition, int LvlArmor, int LvlManeuver, string Name)
        {

            this.Ammunition = Ammunition;
            this.LvlArmor = LvlArmor;
            this.LvlManeuver = LvlManeuver;
            this.Name = Name;
        }
        public tank()
        {
            Ammunition = 0;
            LvlArmor = 0;
            LvlManeuver = 0;
            Name = "null";
        }
        public void Print()
        {
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Ammunition = " + Ammunition + " LvlArmor = " + LvlArmor + " LvlManeuver = " + LvlManeuver);
        }

        public static tank operator *(tank T34, tank pantera)
        {
            if (T34.Ammunition > pantera.Ammunition && T34.LvlArmor > pantera.LvlArmor)
            {
                return T34;
            }
            if (T34.Ammunition > pantera.Ammunition && T34.LvlManeuver > pantera.LvlManeuver)
            {
                return T34;
            }
            if (T34.LvlArmor > pantera.LvlArmor && T34.LvlManeuver > pantera.LvlManeuver)
            {
                return T34;
            }
            else
            {
                return pantera;
            }
        }
    }
}

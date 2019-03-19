using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfTAnks
{
    class Program
    {
        static void Main(string[] args)
        {
            tank tank = new tank();
            tank[] Win = new tank[7];
            tank[] TankT34 = new tank[7];
            tank[] TankPantera = new tank[7];

            Random rand = new Random();

            for (int i = 0; i < TankT34.Length; i++)
            {
                Win[i] = new tank();
            }
            for (int i = 0; i < TankT34.Length; i++)
            {
                TankT34[i] = new tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "T34");
            }

            for (int i = 0; i < TankT34.Length; i++)
            {
                TankPantera[i] = new tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "Pantera");
            }
            for (int i = 0; i < 7; i++)
            {
                TankT34[i].Print();
                TankPantera[i].Print();
                Win[i] = TankT34[i] * TankPantera[i];
                Console.WriteLine();
                Console.WriteLine($"В {i + 1} схватке победил");

                Win[i].Print();
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------");
            }

            Console.ReadLine();


        }
    }
}
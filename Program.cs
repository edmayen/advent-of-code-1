using System;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double mass;
            double fuel;
            string aux;
            string res;
            int exit = 0;
            double total = 0;
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Day 1: The Tyranny of the Rocket Equation");
            Console.WriteLine("_________________________________________");
            Console.WriteLine("\n\n\n");
            do{
                Console.Write("Please, enter the mass: ");
                aux = Console.ReadLine();
                mass = double.Parse(aux);
                fuel = getFuel(mass);
                total = total + fuel;
                Console.WriteLine("\n");
                Console.Write("Do you wanto to introduce another mass? yes/no: ");
                res = Console.ReadLine();
                Console.WriteLine("\n");
                if(string.Equals(res, "yes"))
                {
                    exit = 0;
                }
                else
                {
                    exit = 1;
                }
            }while(exit == 0);
            Console.WriteLine("_________________________________________");
            Console.WriteLine("The Fuel Counter-Upper needs " + total + " of fuel.");
            Console.WriteLine("\n\n\n\n\n");
        }

        public static double getFuel(double mass)
        {
            double div;
            double round;
            double fuel = 0;
            double totalFuel = 0;
            if(mass <= 6)
            {
                fuel = 0;
            }
            else
            if(mass > 6)
            {
                do
                {
                    div = (mass / 3);
                    round = Math.Floor(div);
                    fuel = round - 2;
                    totalFuel = totalFuel + fuel;
                    mass = fuel;
                }while(fuel > 6);
            }
            return totalFuel;
        }
    }
}

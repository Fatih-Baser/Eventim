using FactoryMethodPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            factory hotel = new wybor();
         
            Interface pokojstandard = hotel.GetMiejsca("miejscastandard");
            pokojstandard.Rozpiska(100, 3);
            Interface pokojpremium = hotel.GetMiejsca("miejscapremium");
            pokojpremium.Rozpiska(200, 2);
            Console.ReadKey();

        }
    }
}

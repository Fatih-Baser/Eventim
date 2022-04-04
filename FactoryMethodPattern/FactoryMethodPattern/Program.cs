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
            factory koncert = new wybormiejsca();
         
            Interface pokojstandard = koncert.GetMiejsca("miejscastandard");
            pokojstandard.Koncertbilet(100, 53);
            Interface pokojpremium = koncert.GetMiejsca("miejscapremium");
            pokojpremium.Koncertbilet(200, 2);
            Console.ReadKey();

        }
    }
}

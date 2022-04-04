using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Classes
{
    internal class miejscastandard : Interface 
    {
        public void Koncertbilet(int cena, int numersiedzenia)
        {
            Console.WriteLine("Miejsca Standart cena " + cena + "zl. \n Numer siedzenia: " + numersiedzenia);
        }
    }
}

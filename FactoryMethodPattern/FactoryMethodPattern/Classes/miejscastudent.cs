using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Classes
{
    internal class miejscastudent : Interface 
    {
        public void Rozpiska(int cena, int numersiedzenia)
        {
            Console.WriteLine("Miejsca Student cena " + cena + "zl. \n Numer siedzenia: " + numersiedzenia);
        }
    }
}

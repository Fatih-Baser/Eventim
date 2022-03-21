using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonExample
{
    internal class main
    {
        static void Main(string[] args)
        {

            Singleton singleton = Singleton.Instancja;
            singleton.Okres = 30;
            singleton.Rodzaj_miejsca = "Premium";
            singleton.Imie_i_nazwisko = "Fatih Baser";
            Console.WriteLine("Miejsca " + singleton.Rodzaj_miejsca + " Posiadacz biletu = " + singleton.Imie_i_nazwisko + " na okres " + singleton.Okres);
            Console.ReadKey();


        }


    }
}


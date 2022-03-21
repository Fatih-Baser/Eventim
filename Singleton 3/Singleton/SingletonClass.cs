using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class Singleton
    {

        private static Singleton instancja = new Singleton();


        private int okres;
        private string rodzaj_miejsca, imie_i_nazwisko  ;

        private Singleton() { }


        internal static Singleton Instancja
        {
            get => instancja;
            set => instancja = value;
        }

        public int Okres { get => okres; set => okres = value; }
        public string Rodzaj_miejsca { get => rodzaj_miejsca; set => rodzaj_miejsca = value; }
        public string Imie_i_nazwisko { get => imie_i_nazwisko; set => imie_i_nazwisko = value; }


    }



}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Classes
{
    class Facade
    {
        EventimNamee name;
        EventimSurname surname;
        EventimPhoneNo phoneno;
        EventimMiejsca miejsca;

        public Facade()
        {
            name = new EventimNamee();
            surname = new EventimSurname();
            phoneno = new EventimPhoneNo();
            miejsca = new EventimMiejsca();
        }

        public void Create()
        {
            Console.WriteLine("******** Creating ...**********\n");

            Console.WriteLine("Wpisz imie = ");
            string name1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Wpisz nazywisko = ");
            string surname1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Wpisz phone no = ");
            string phoneno1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Wpisz miejsca  = ");
            string miejsca1 = Convert.ToString(Console.ReadLine());

            name.Setname(name1);
            surname.SetSurname(surname1);
            phoneno.SetPhoneNo(phoneno1);
            miejsca.SetMiejsca(miejsca1);

            Console.WriteLine("\n******** Creation complete **********");
        }
    }
}

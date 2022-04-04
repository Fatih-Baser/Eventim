using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterClassPattern.Classes
{
    public static class EventimDataProvider
    {
        public static List<Eventim> GetData() =>
        new List<Eventim>
        {
            new Eventim { Name = "Example1", Surname = "ExampleSurname1", PhoneNo = 50202434,Miejsca = "4"},
            new Eventim { Name = "Example2", Surname = "ExampleSurname2", PhoneNo = 2016,Miejsca = "5"},
            new Eventim { Name = "Example3", Surname = "ExampleSurname3", PhoneNo = 2016,Miejsca = "6"},
            new Eventim { Name = "Example4", Surname = "ExampleSurname4", PhoneNo = 2016,Miejsca = "7"},
            new Eventim { Name = "Example5", Surname = "ExampleSurname5", PhoneNo = 2016,Miejsca = "8"}
        };
    }
}

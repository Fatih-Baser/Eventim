using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    class Eventim
    {
        public int ID { get; set; }
        public string KoncertName { get; set; }
        public Eventim(string koncertName, int id)
        {
            KoncertName = koncertName;
            ID = id;
        }
    }
}

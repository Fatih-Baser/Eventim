using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class SingletonClass
    {
        // private instance of the class
        private static SingletonClass instance = new SingletonClass();

        // some variables 
        private int count;
        private string name;

        // private constructor
        private SingletonClass() { }

        // static accessories for the instance of singleton class
        // The internal keyword is an access modifier for types and type members.
        internal static SingletonClass Instance {
            get => instance;
            set => instance = value;
        }

        public int Count { get => count; set => count = value; }
        public string Name { get => name; set => name = value; }

        
    }
}


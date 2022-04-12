using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorDesignPattern;

namespace IteratorPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Build a collection
            ConcreteCollection collection = new ConcreteCollection();
            collection.AddKoncert(new Eventim("Anurag", 100));
            collection.AddKoncert(new Eventim("Pranaya", 101));
            collection.AddKoncert(new Eventim("Santosh", 102));
            collection.AddKoncert(new Eventim("Priyanka", 103));
            collection.AddKoncert(new Eventim("Abinash", 104));
            collection.AddKoncert(new Eventim("Preety", 105));

            // Create iterator
            Iterator iterator = collection.CreateIterator();
            //looping iterator      
            Console.WriteLine("Iterating over collection:");

            for (Eventim emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                Console.WriteLine($"ID : {emp.ID} & Name : {emp.KoncertName}");
            }
            Console.Read();
        }
    }
}

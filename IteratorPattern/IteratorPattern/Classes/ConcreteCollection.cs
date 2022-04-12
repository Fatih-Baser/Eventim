using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    class ConcreteCollection :AbstractCollection
    {
        private List<Eventim> listKoncerts = new List<Eventim>();
        //Create Iterator
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        // Gets item count
        public int Count
        {
            get { return listKoncerts.Count; }
        }
        //Add items to the collection
        public void AddKoncert(Eventim koncert)
        {
            listKoncerts.Add(koncert);
        }
        //Get item from collection
        public Eventim GetKoncert(int IndexPosition)
        {
            return listKoncerts[IndexPosition];
        }
    }
}

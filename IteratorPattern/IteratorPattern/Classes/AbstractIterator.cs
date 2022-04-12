using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    interface AbstractIterator
    {
        Eventim First();
        Eventim Next();
        bool IsCompleted { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPatternCSharp.Iterator;

namespace IteratorPatternCSharp.Aggregate
{
    public interface ISocialNetworking
    {
        IIterator CreateIterator();
    }
}

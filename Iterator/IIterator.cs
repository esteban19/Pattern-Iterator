using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternCSharp.Iterator
{
    public interface IIterator
    {
        void First();//reset back to first element
        string Next();//get next
        bool IsDone();//end of collection check
        string CurrentItem();//get current item
    }
}

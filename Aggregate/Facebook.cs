using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPatternCSharp.Iterator;

namespace IteratorPatternCSharp.Aggregate
{
    public class Facebook : ISocialNetworking
    {
        private LinkedList<string> users;

        public Facebook()
        {
            //Sign up for a facebook account
            users = new LinkedList<string>();
            users.AddLast("Mike");
            users.AddLast("Jason");
            users.AddLast("Kristen");
            users.AddLast("Ashley");
            users.AddLast("Brandon");
            users.AddLast("Srikanth");
            users.AddLast("Hitomi");
        }

        public Iterator.IIterator CreateIterator()
        {
            return new FacebookIterator(users);
        }
    }
}

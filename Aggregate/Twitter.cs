using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPatternCSharp.Iterator;

namespace IteratorPatternCSharp.Aggregate
{
    public class Twitter : ISocialNetworking
    {
        private string[] users;

        public Twitter()
        {
            users = new[] { "Kathy", "Lori", "Kristen", "Jamie" };
        }

        public Iterator.IIterator CreateIterator()
        {
            return new TwitterIterator(users);
        }
    }
}

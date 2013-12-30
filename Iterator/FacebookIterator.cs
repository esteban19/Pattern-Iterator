using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternCSharp.Iterator
{
    public class FacebookIterator : IIterator
    {
        private LinkedList<string> users;
        private int position;

        public FacebookIterator(LinkedList<string> newUsers)
        {
            this.users = newUsers;
            this.position = 0;
        }

        public void First()
        {
            position = 0;
        }

        public string Next()
        {
            return users.ElementAt(position++);
        }

        public bool IsDone()
        {
            return position >= users.Count;
        }

        public string CurrentItem()
        {
            return users.ElementAt(position);
        }
    }
}

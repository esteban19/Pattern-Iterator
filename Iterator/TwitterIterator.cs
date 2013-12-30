using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternCSharp.Iterator
{
    public class TwitterIterator : IIterator
    {
        private string[] users;
        int position = 0;

        public TwitterIterator(string[] newUsers)
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
            return users[position++];
        }

        public bool IsDone()
        {
            return position >= users.Length;
        }

        public string CurrentItem()
        {
            return users[position];
        }
    }
}

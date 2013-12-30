using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPatternCSharp.Aggregate;
using IteratorPatternCSharp.Iterator;

namespace IteratorPatternCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ISocialNetworking fb = new Facebook();
            ISocialNetworking tw = new Twitter();

            IIterator fbIterator = fb.CreateIterator();
            IIterator twIterator = tw.CreateIterator();

            Console.WriteLine("Facebook: ");
            PrintUsers(fbIterator);

            Console.WriteLine("Twitter: ");
            PrintUsers(twIterator);

        }

        public static void PrintUsers(IIterator iterate)
        {
            iterate.First();
            while (!iterate.IsDone())
            {
                Console.WriteLine("1:{0}",iterate.CurrentItem());//current
                Console.WriteLine("2:{0}",iterate.Next());//current,advanceby(1)
            }
        }
    }
}

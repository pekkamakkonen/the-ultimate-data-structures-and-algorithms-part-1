using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            // list.AddFirst(5);
            // list.RemoveFirst();
            Console.WriteLine(list.Contains(5));
          //  Console.WriteLine(list.IndexOf(10));
          //  Console.WriteLine(list.Size());
            var array = list.ToArray();
            Console.WriteLine(Arrays.ToString())
          //  Console.WriteLine(list);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> myList = new List<object>();
            myList.Add(7);
            myList.Add(28);
            myList.Add(-1);
            myList.Add(true);
            myList.Add("chair");
            foreach (var item in myList)
            {
                int sum = 0;
                if (item is int)
                {
                    System.Console.WriteLine(item);
                    sum += (int)item;
                }
                if (item is string)
                {
                    System.Console.WriteLine(item);
                }
                if (item is bool)
                {
                    System.Console.WriteLine(item);
                }
            }
        }
    }
}

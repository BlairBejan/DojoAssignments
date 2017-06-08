using System;
using System.Collections.Generic;

namespace collections_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zerotonine = {0,1,2,3,4,5,6,7,8,9};
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] truefalse = new bool[10];
            for (int i = 0; i < truefalse.Length; i++)
            {
                if (i % 2 == 0)
                {
                    truefalse[i] = true;
                }
                else{
                    truefalse[i] = false;
                }
            }
            int[,] table = new int[10,10];
            for (int i = 0; i < 10; i++)
            {
                for (int x = 0; x < 10; x++)
                {
                    table[i,x] = i * x;
                }
            }
            List<string> icecreamflavors = new List<string>();
            icecreamflavors.Add("vanilla");
            icecreamflavors.Add("chocolate");
            icecreamflavors.Add("strawberry");
            icecreamflavors.Add("coffee");
            icecreamflavors.Add("radicalrasberry");

            Dictionary<string,string> userinfo = new Dictionary<string,string>();
            userinfo.Add(names[0], null);
            userinfo.Add(names[1], null);
            userinfo.Add(names[2], null);
            userinfo.Add(names[3], null);
            
        }
    }
}

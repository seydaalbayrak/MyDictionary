using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
        
          

            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("txt", 25);
            myDictionary.Add("txt2", 30);
            myDictionary.Add("txt3", 35);

            Console.WriteLine(myDictionary.Count());

           
        }
    }
}

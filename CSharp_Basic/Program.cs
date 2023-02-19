using project01.C_Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashTable_Demo hastTable = new HashTable_Demo();
            SortedList_Demo sortedList = new SortedList_Demo();

            Console.WriteLine("=====HashTable===========");
            hastTable.demo();
            Console.WriteLine("================");

            Console.WriteLine("=====SortedList============");
            sortedList.demo();
            Console.WriteLine("================");


            Console.ReadKey();
        }
    }
}

using CSharp_Basic.item;
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
            Stack_Demo stack = new Stack_Demo();    
            Queue_Demo queue = new Queue_Demo();    
            BitArray_Demo bitArray = new BitArray_Demo();
            Generic_Demo generic_Demo= new Generic_Demo();

            //Console.WriteLine("=====HashTable===========");
            //hastTable.demo();
            //Console.WriteLine("================");

            //Console.WriteLine("=====SortedList============");
            //sortedList.demo();
            //Console.WriteLine("================");

            //Console.WriteLine("=====Stack============");
            //stack.demo();
            //Console.WriteLine("================");

            //Console.WriteLine("=====Queue============");
            //queue.demo();
            //Console.WriteLine("================");

            //Console.WriteLine("=====Queue============");
            //bitArray.demo();
            //Console.WriteLine("================");

            Console.WriteLine("=====Queue============");
            generic_Demo.demo();
            Console.WriteLine("================");

            Console.ReadKey();
        }
    }
}

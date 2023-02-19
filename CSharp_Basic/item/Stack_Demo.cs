using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basic.item
{
    public class Stack_Demo
    {
        public void demo()
        {
            Stack stack1 = new Stack();
            stack1.Push("Phan tu 1");
            stack1.Push("Phan tu 2");
            stack1.Push("Phan tu 3");

            Console.WriteLine("So phan tu cua stack la: " + stack1.Count);

            //lay ra danh sach cac phan tu trong stack ma ko remove
            Console.WriteLine("Phan tu cuoi cua stack la: "+stack1.Peek());

            int lenght = stack1.Count;
            Console.WriteLine("poping......");
            for (int i = 0; i < lenght; i++)
            {
                //lay ra danh sach cac phan tu trong stack va remove khoi stack
                Console.Write(" || "+ stack1.Pop()+ " || ");
            }


            Console.WriteLine();
        }
    }
}

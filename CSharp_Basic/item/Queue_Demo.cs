using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basic.item
{
    public class Queue_Demo
    {
        public void demo()
        {
            ArrayList arr   = new ArrayList();
            Queue queue1 = new Queue();
            queue1.Enqueue("obj1");
            queue1.Enqueue("obj2");
            queue1.Enqueue("obj3");


            int lenght = queue1.Count;

            //Chi lay ra chu ko xoa phan tu do
            Console.WriteLine("Phan tu dau tien cua queue la: "+ queue1.Peek());

            for (int i= 0; i<lenght; i++)
            {
                //Dequeue lay phan tu va xoa phan tu do
                Console.Write(" || "+ queue1.Dequeue()+ " || ");
            }

            Console.WriteLine();
        }
    }
}

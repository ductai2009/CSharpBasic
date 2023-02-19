using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basic.item
{
    public class Generic_Demo
    {
        public void demo()
        {
            int a = 4;
            int b = 5;
            Console.WriteLine($"<chua Swap> a: {a} va b: {b}");
            swap<int>(ref a, ref b);

            Console.WriteLine($"<Da Swap> a: {a} va b: {b}");
        }
        void swap<G>(ref G a, ref G b)
        {
            G c = a;
            a = b;
            b = c;
        }
    }
}

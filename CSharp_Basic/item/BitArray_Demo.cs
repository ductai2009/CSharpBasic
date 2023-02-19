using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basic.item
{
    public class BitArray_Demo
    {
        public void demo()
        {
            bool[] bool1 = new bool[] { true, false, true, false, true };


            int[] int1 = new int[] {1, 2 , 3, 4, 5};

            BitArray bitArray1 = new BitArray(bool1);    
            BitArray bitArray2 = new BitArray(int1);

            printBitInt(int1);
            Console.WriteLine("=========");
            printBitBool(bool1);
            Console.WriteLine("=========BitArr Bool");
            printBitArr(bitArray1);
            Console.WriteLine("=========BitArray int");
            printBitArr(bitArray2);

            Console.WriteLine();

            void printBitArr(BitArray arr)
            {
                int totalBits = arr.Length;
                Console.WriteLine("Tong so Bit: " + totalBits);

                for (int i = 0; i < totalBits; i++)
                {
                    Console.Write(arr.Get(i) ? "1" : "0");
                }
                Console.WriteLine();
            }

            void printBitInt(int[] arr)
            {
                int arrayLength = arr.Length;
                int totalBits = arrayLength * 32;
                Console.WriteLine($"Tong so bit trong mang: {totalBits}");

                for (int i = 0; i < arrayLength; i++)
                {
                    Console.Write(Convert.ToString(arr[i], 2).PadLeft(32, '0'));
                    if(i/8 == 0)
                    {
                        Console.WriteLine();
                    }

                }
                Console.WriteLine();

            }
            void printBitBool(bool[] arr)
            {

                int boolArrayLength = arr.Length;
                int boolTotalBits = boolArrayLength * 1;
                Console.WriteLine($"Tong so bit trong mang bool: {boolTotalBits}");

                Console.WriteLine("Bit Arr");
                for (int i = 0; i < boolArrayLength; i++)
                {
                    Console.Write(arr[i] ? "1" : "0");
                }
                Console.WriteLine();

            }



        }
        

    }
}

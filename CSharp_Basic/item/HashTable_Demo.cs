using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace project01.C_Sharp
{
    public class HashTable_Demo
    {
        public void demo()
        {
            Hashtable hashTable1 = new Hashtable();

            hashTable1.Add(1, "so mot");
            hashTable1.Add(2, "so hai");

            // mỗi dữ liệu trong hashtable là 1 DictionaryEntry
            foreach (DictionaryEntry hs in hashTable1)
            {
                Console.WriteLine("Key của hastable1 là: " + hs.Key + " và value của hastable là: " + hs.Value);
                Console.WriteLine("=====");
            }

            // Đếm số từ xuất hiện nhiều nhất trong câu
            //Console.WriteLine("Nhap cau:");
            //String text = Console.ReadLine();
            String text = "cái này là để để đếm từ xuất hiện nhiều nhất trong câu";
            demSoLanXuatHien(text);

        }
        static void demSoLanXuatHien(String text)
        {
            Hashtable dic = new Hashtable();
            int ind = 1;
            foreach (String t in text.Split(' '))
            {
                if (!dic.Contains(t))
                {
                    dic.Add(t, ind);
                }
                else
                {
                    int temp = Convert.ToInt32(dic[t]);
                    dic[t] = temp + 1;
                }

            }
            int tempValue = 0;
            String tuXuatHienNhieu = "";
            foreach (DictionaryEntry hs in dic)
            {
                if (Convert.ToInt32(hs.Value) >= tempValue)
                {
                    tempValue = Convert.ToInt32(hs.Value);
                    tuXuatHienNhieu = Convert.ToString(hs.Key);

                }
            }
            Console.WriteLine("Từ xuất hiện nhiều nhất trong câu là từ: \"" + tuXuatHienNhieu + "\". Với số lần xuất hiện là: " + tempValue);
        }


    }
}

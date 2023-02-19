using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project01.C_Sharp
{
    public class SortedList_Demo
    {
        public void demo()
        {
            SortedList mSort = new SortedList(new Sort_List());
            DateTime day1 = DateTime.Now;
            DateTime day2 = day1.AddDays(-1);
            DateTime day3 = day1.AddDays(1);

            mSort.Add(new ChiTieu(day1.Date, 100000), 1);
            mSort.Add(new ChiTieu(day2.Date, 130000), 2);
            mSort.Add(new ChiTieu(day3.Date, 110000), 3);

            show_SortList(mSort);
        }
        void show_SortList(SortedList x)
        {
            foreach (DictionaryEntry dic in x)
            {
                Console.WriteLine("STT: " + dic.Value + " Chi Tieu(Ngay - Tong Chi)" + dic.Key);
                Console.WriteLine("=======");
            }
        }

    }
    class ChiTieu
    {
        private DateTime day;
        private int tongChi;

        public ChiTieu(DateTime day, int tongChi)
        {
            this.Day = day;
            this.TongChi = tongChi;
        }

        public DateTime Day { get => day; set => day = value; }
        public int TongChi { get => tongChi; set => tongChi = value; }

        public override String ToString()
        {
            return "Ngay: " + day + " Tong Chi: " + tongChi;
        }

    }
    class Sort_List : IComparer
    {
        public int Compare(object x, object y)
        {
            ChiTieu x1 = x as ChiTieu;
            ChiTieu y1 = y as ChiTieu;
            if (x1 == null || y1 == null)
            {
                throw new Exception();
            }
            else
            {
                if (x1.TongChi > y1.TongChi)
                {
                    return 1;
                }
                else if (x1.TongChi == y1.TongChi)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }

        }

    }
}

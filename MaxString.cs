using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics1
{
    internal class MaxString
    {
        static void Main()
        {
            //TC1
            string MaxNum1 = MaxofThree("Orange", "Banana", "Apple");
            Console.WriteLine("Max Num is :" + MaxNum1);
            //TC2
            string MaxNum2 = MaxofThree("Banana", "Orange", "Apple");
            Console.WriteLine("Max Num is :" + MaxNum2);
            //TC3
            string MaxNum3 = MaxofThree("Apple", "Banana", "Orange");
            Console.WriteLine("Max Num is :" + MaxNum3);
        }

        public static string MaxofThree(string str1, string str2, string str3)
        {
            string MaxOfstr = str1;
            if (str2.CompareTo(MaxOfstr) > 0)
            {
                MaxOfstr = str2;
            }
            if (str3.CompareTo(MaxOfstr) > 0)
            {
                MaxOfstr = str3;
            }
            return MaxOfstr;
        }
    }
}

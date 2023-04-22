using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics1
{
    internal class Maxof3Int
    {
        static void Main()
        {
            //TC1
            int MaxNum1 = MaxofThree(30, 20, 10);
            Console.WriteLine("Max Num is :"+MaxNum1);
            //TC2
            int MaxNum2 = MaxofThree(30, 40, 20);
            Console.WriteLine("Max Num is :" + MaxNum2);
            //TC3
            int MaxNum3 = MaxofThree(30, 40, 50);
            Console.WriteLine("Max Num is :" + MaxNum3);
        }

        public static int MaxofThree(int num1, int num2, int num3)
        {
            int MaxOfNum = num1;
            if (num2.CompareTo(MaxOfNum) > 0)
            {
                MaxOfNum = num2;
            }
            if (num3.CompareTo(MaxOfNum) > 0)
            {
                MaxOfNum = num3;
            }
            return MaxOfNum;
        }

    }

}

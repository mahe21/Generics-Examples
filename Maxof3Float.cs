using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics1
{
    internal class Maxof3Float
    {
        static void Main()
        {
            //TC1
            float MaxNum1 = MaxofThree(30.1f, 20.0f, 10.2f);
            Console.WriteLine("Max Num is :" + MaxNum1);
            //TC2
            float MaxNum2 = MaxofThree(30.1f, 40.4f, 20.3f);
            Console.WriteLine("Max Num is :" + MaxNum2);
            //TC3
            float MaxNum3 = MaxofThree(30.4f, 40.3f, 50.5f);
            Console.WriteLine("Max Num is :" + MaxNum3);
        }

        public static float MaxofThree(float num1, float num2, float num3)
        {
            float MaxOfNum = num1;
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

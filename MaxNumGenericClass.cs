using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics1
{
    public class MaxNumGenericClass<T> where T : IComparable<T>
    {
        private T Value1; 
        private T Value2; 
        private T Value3;

        public MaxNumGenericClass(T value1, T value2, T value3)
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }
       

        private static T MaxNum(T num1, T num2, T num3)
        {
            T MaximumNum = num1;
            if (num2.CompareTo(MaximumNum) > 0)
            {
                MaximumNum = num2;
            }
            if (num3.CompareTo(MaximumNum) > 0)
            {
                MaximumNum = num3;
            }
            return MaximumNum;
        }
        public T FindMax()
        {
            return MaxNum(Value1, Value2, Value3);
        }

        public static void Main()
        {
            MaxNumGenericClass<int> IntValue = new MaxNumGenericClass<int>(10, 20, 5);
            int MaxInt = IntValue.FindMax();
            Console.WriteLine("Max int value is: " + MaxInt);

            MaxNumGenericClass<float> FloatValue = new MaxNumGenericClass<float>(10.0f, 20.3f, 5.3f);
            float MaxFloat = FloatValue.FindMax();
            Console.WriteLine("Max float value is: " + MaxFloat);

            MaxNumGenericClass<string> StrValue = new MaxNumGenericClass<string>("Apple", "Banana", "Orange");
            string MaxStr = StrValue.FindMax();
            Console.WriteLine("Max string value is: " + MaxStr);
        }

    }
}

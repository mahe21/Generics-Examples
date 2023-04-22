using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics1
{
    public class GenericMax<T> where T : IComparable<T>
    {
        private T var1;
        private T var2;
        private T var3;

        public GenericMax(T var1, T var2, T var3)
        {
            this.var1 = var1;
            this.var2 = var2;
            this.var3 = var3;
        }

        public void TestMaximum()
        {
            T max = Max(var1, var2, var3);
            PrintMax(max);
        }

        public static T Max<T>(T a, T b, T c) where T : IComparable<T>
        {
            T max = a;
            if (b.CompareTo(max) > 0)
            {
                max = b;
            }
            if (c.CompareTo(max) > 0)
            {
                max = c;
            }
            Console.WriteLine($"The maximum value is: {max}");
            return max;
        }

        private void PrintMax(T max)
        {
            Console.WriteLine($"The maximum value is: {max}");
        }

        public static void Main()
        {
            GenericMax<int> integerMax = new GenericMax<int>(1, 2, 3);
            integerMax.TestMaximum();

            GenericMax<double> doubleMax = new GenericMax<double>(1.1, 2.2, 3.3);
            doubleMax.TestMaximum();
        }
    }
}

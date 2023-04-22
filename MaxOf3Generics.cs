namespace Generics1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //TC1
            int Maximum = FindMax(40, 23, 15);
            Console.WriteLine("Max value is :" +Maximum);

            //TC2
            float Maximum2 = FindMax(21.2f, 34.5f, 10.4f);
            Console.WriteLine("Max value is :" + Maximum2);

            //TC3
            string Maxstr3 = FindMax("Apple", "Orange", "Banana");
            Console.WriteLine("Max value is :" + Maxstr3);

        }

        public static T FindMax<T>(T a, T b, T c) where T : IComparable<T>
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
            return max;
        }
    }
}
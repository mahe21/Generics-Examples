namespace Generics1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maxof3Int maxof3Int = new Maxof3Int();

            //TC1
            int Maximum = Maxof3Int.MaxofThree(12, 23, 45);
            Console.WriteLine("Max value is :" +Maximum);

            //TC2
            double Maximum2 = Maxof3Int.MaxofThree(21.4, 34.2, 1.2);
            Console.WriteLine("Max value is :" + Maximum2);

            //TC3
            float Maximum3 = (float)Maxof3Int.MaxofThree(21.4, 20, 10.2);
            Console.WriteLine("Max value is :" + Maximum3);



        }
    }
}
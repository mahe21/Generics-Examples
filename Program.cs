namespace Generics1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maxof3Int maxof3Int = new Maxof3Int();

            //TC1
            int Maximum = Maxof3Int.MaxofThree(40, 23, 15);
            Console.WriteLine("Max value is :" +Maximum);

            //TC2
            int Maximum2 = Maxof3Int.MaxofThree(21, 34, 1);
            Console.WriteLine("Max value is :" + Maximum2);

            //TC3
            int Maximum3 = Maxof3Int.MaxofThree(19, 20, 45);
            Console.WriteLine("Max value is :" + Maximum3);



        }
    }
}
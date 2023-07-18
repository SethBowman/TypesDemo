namespace TypesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Show how variables work first
            // Name - Type - Value
            int number = 12;

            double doubleNumber = 20.5;

            string myWord = "Howdy!";

            bool isAlive = true;


            //VALUE TYPES EXAMPLE

            int a = 1;
            int b = a;

            a = 25;

            // a = 25 b = 1
            Console.WriteLine("A and B");
            Console.WriteLine(a);
            Console.WriteLine(b);

            //REFERENCE TYPES EXAMPLE

            var p1 = new Point();

            p1.X = 1;

            var p2 = p1;

            p1.X = 500;
            Console.WriteLine("p1.X and p2.X");
            Console.WriteLine(p1.X);
            Console.WriteLine(p2.X);

        }
    }
}
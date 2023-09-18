namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Jane";
            byte age = 27;
            ushort shoeSize = 42;
            bool isPet = true;
            Console.WriteLine(MyName);

            Console.WriteLine("\tПривет,\n Мир!");
            Console.WriteLine("\tМне {0} лет", age);
            Console.WriteLine("\tMy name is\n {0}", MyName);
            Console.WriteLine("\tDo I have a pet?\n\t {0}", isPet);
            Console.WriteLine("\tMy shoe size is {0}", shoeSize);


            Console.ReadKey();
        }
    }
}
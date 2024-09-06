namespace Electiva2_repo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cual es tu nombre?");
            var name = Console.ReadLine();
            Console.WriteLine($"Tu nombre es {name}");
        }
    }
}

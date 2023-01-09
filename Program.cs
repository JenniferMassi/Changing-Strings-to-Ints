namespace Changing_strings_to_integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int num = 0;
            string num2 = "50";
            num2 = Console.ReadLine();
            Console.WriteLine("Write a number");
            
            num = int.Parse(num2);

            Console.WriteLine(num + 40);
        }
    }
}
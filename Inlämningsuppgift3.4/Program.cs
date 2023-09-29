using System; 
namespace inlämningsuppgift3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in antal minuter låten är: ");
            string x = Console.ReadLine();
            int minuter = Convert.ToInt32(x);
            Console.WriteLine("Skriv in antal sekunder låten är: ");
            string y = Console.ReadLine();
            int sekunder = Convert.ToInt32(y);
            Console.Clear();
            if (minuter >= 4 && sekunder >= 20)
            {
                Console.WriteLine("Låten är för stor och därav är inte kvalificerad");
            }
            else
            {
                Console.WriteLine("Låten är kvalificerad");
            }
        }
    }
}
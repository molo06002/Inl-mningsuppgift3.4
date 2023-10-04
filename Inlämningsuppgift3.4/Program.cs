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

            int stor = (4*60)+20;
            int liten = (2*60)+45;

            int minuter1 = (minuter * 60) + sekunder;
            Console.Clear();

            if (minuter1 >= liten && minuter1 <= stor)
            {
                Console.WriteLine("Låten är kvalificerad");
            }
            else
            {
                Console.WriteLine("Låten är antingen för stor eller för liten");//
            }
        }
    }
}
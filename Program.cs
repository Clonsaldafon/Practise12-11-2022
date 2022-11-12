using Microsoft.VisualBasic.FileIO;

namespace Practise12_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите континент: ");
            string continent = Console.ReadLine();

            Handler handler = new Handler();
            
            List<Country> countries = handler.Read(continent);
            countries = handler.Sort(countries);

            foreach(var item in countries)
            {
                Console.WriteLine(item.Population);
            }
        }
    }
}
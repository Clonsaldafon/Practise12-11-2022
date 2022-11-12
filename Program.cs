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

            handler.Countries = handler.Read(continent);
            handler.Countries = handler.Sort(handler.Countries);
        }
    }
}
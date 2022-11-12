using System.Text;

namespace Practise12_11_2022
{
    internal class Writer
    {
        public static void WriteToFile(List<Country> list)
        {
            Console.Write("Введите название файла: ");
            string input = Console.ReadLine();

            using (StreamWriter newFile = new StreamWriter($"..\\..\\..\\{input}.txt"))
            {
                newFile.WriteLine("Страна;Столица;Площадь;Население;Континент");

                foreach (Country item in list)
                {
                    newFile.WriteLine($"{item.Name};{item.Capital};{item.Area};{item.Population};{item.Continent}");
                }
            }
        }
    }
}

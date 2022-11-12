using System.Text;

namespace Practise12_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите континент: ");
            string continent = Console.ReadLine();

            Handler handler = new Handler();
            
            handler.Read(continent);
            handler.Sort();
        }

        public static void WriteToFile(List<Country> list)
        {
            Console.WriteLine("Введите название файла:");
            string input = Console.ReadLine();

            StringBuilder builder = new StringBuilder();
            builder.Append(input);

            foreach (Country item in list)
                builder.Append(item);

            StreamWriter newFile = new StreamWriter("C:\\NewFile.txt");
            newFile.Write(builder.ToString());
        }
    }
}
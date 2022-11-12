using System.Text;

namespace Practise12_11_2022
{
    internal class Writer
    {
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

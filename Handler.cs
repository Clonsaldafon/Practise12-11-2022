using Microsoft.VisualBasic.FileIO;
using System;

namespace Practise12_11_2022
{
    internal class Handler
    {
        public List<Country> Countries = new List<Country>();

        public void Read(string continent)
        {
            bool isFirstLine = true;
            using (TextFieldParser parser = new TextFieldParser("..\\..\\..\\country.txt"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    if (!isFirstLine)
                    {
                        if (fields[fields.Length - 1] == continent)
                        {
                            Countries.Add(
                                new Country(fields[0], fields[1], int.Parse(fields[2]), int.Parse(fields[3]), fields[4])
                            );
                        }
                    }
                    else
                    {
                        isFirstLine = false;
                    }
                }
            }
        }

        public void Sort()
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                for (int j = 0; j < Countries.Count - 1; j++)
                {
                    if (Countries[j].Population > Countries[j + 1].Population)
                    {
                        Country temp = Countries[j + 1];
                        Countries[j + 1] = Countries[j];
                        Countries[j] = temp;
                    }
                }
            }
        }
    }
}

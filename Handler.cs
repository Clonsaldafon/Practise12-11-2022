using Microsoft.VisualBasic.FileIO;
using System;

namespace Practise12_11_2022
{
    internal class Handler
    {
        public List<Country> Countries = new List<Country>();

        public List<Country> Read(string continent)
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

            return Countries;
        }

        public List<Country> Sort(List<Country> countries)
        {
            for (int i = 0; i < countries.Count; i++)
            {
                for (int j = 0; j < countries.Count - 1; j++)
                {
                    if (countries[j].Population > countries[j + 1].Population)
                    {
                        Country temp = countries[j + 1];
                        countries[j + 1] = countries[j];
                        countries[j] = temp;
                    }
                }
            }

            return countries;
        }
    }
}

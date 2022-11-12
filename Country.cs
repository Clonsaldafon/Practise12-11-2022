using System;

namespace Practise12_11_2022
{
    internal class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public int Area { get; set; }
        public int Population { get; set; }
        public string Continent { get; set; }

        public Country(string name, string capital, int area, int population, string continent)
        {
            Name = name;
            Capital = capital;
            Area = area;
            Population = population;
            Continent = continent;
        }
    }
}

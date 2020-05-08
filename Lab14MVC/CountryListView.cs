using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14MVC
{
    class CountryListView
    {
        public List<Country> countries { get; set; }

        public CountryListView(List<Country> countries)
        {
            this.countries = countries;
        }

        public void Display()
        {
            for (int i = 0; i < countries.Count; i++)
            {
                Country c = countries[i];
                Console.WriteLine($"{i + 1}: {c.Name}");
            }
        }
    }
}

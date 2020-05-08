using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14MVC
{
    class CountryController
    {
        public List<Country> CountryDb = new List<Country>();

        public CountryController()
        {
            Country usa = new Country();
            List<string> mericacolor = new List<string>() { "Red", "White", "Blue" };
            usa.Name = "United States of America";
            usa.Continent = "North America";
            usa.Colors = mericacolor;
            CountryDb.Add(usa);
            Country can = new Country();
            List<string> canuckcolor = new List<string>() { "Red", "White" };
            can.Name = "Canada";
            can.Continent = "North America";
            can.Colors = canuckcolor;
            CountryDb.Add(can);
            Country jap = new Country();
            List<string> japcolor = new List<string>() { "White", "Red" };
            jap.Name = "Japan";
            jap.Continent = "Asia";
            jap.Colors = japcolor;
            CountryDb.Add(jap);
            Country col = new Country();
            List<string> colcolor = new List<string>() { "Yellow", "Blue", "Red"};
            col.Name = "Colombia";
            col.Continent = "South America";
            col.Colors = colcolor;
            CountryDb.Add(col);
        }
        public void CountryAction(Country c)
        {
            CountryView country = new CountryView(c);
            country.Display();
        }

        public void WelcomeAction()
        {
            CountryListView countries = new CountryListView(CountryDb);
            while (true)
            {
                try
                {
                    Console.WriteLine("Please select a country from the following list: ");
                    countries.Display();
                    string answer = Console.ReadLine().Trim();
                    int index = int.Parse(answer);
                    CountryAction(CountryDb[index - 1]);
                    break;
                }
                catch(FormatException)
                {
                    Console.WriteLine("That was not a number");
                }
                catch(ArgumentOutOfRangeException)
                {
                    Console.WriteLine("That number did not match anything on our list");
                }
            }
        }
    }
}

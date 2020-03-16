using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Data_Structures_Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			Country[] countryArray = new Country[155];

			try
			{
				StreamReader fileOfCountries = new StreamReader(@"C:\Users\jpdel\Documents\Spring 2020 Data Structures Projects\project3-csharp\Data_Structures_Project_3\Data_Structures_Project_3\Countries3.csv");
				String firstLine = fileOfCountries.ReadLine();
				String nextline;
				int i = 0;
				while ((nextline = fileOfCountries.ReadLine()) != null)
				{
					String[] stats = nextline.Split(',');
					String name = stats[0];
					String code = stats[1];
					String capitol = stats[2];
					long population = Convert.ToInt64(stats[3]);
					if(!Int64.TryParse(stats[4], out long GDP))
					{
						GDP = Convert.ToInt64(stats[4]);
					}
					int happiness = Convert.ToInt32(stats[5]);
					countryArray[i] = new Country(name, code, capitol, population, GDP, happiness);
					i++;
				}

			}
			catch (FileNotFoundException)
			{
				Console.WriteLine("File not found");
			}
			
			for (int i = 0; i < 155; i++)
			{
				countryArray[i].printCountry();
			}
			Console.ReadKey();

		}
    }
}

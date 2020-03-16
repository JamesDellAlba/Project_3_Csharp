using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Project_3
{
    class Country
    {
        private String name;
		private String code;
		private String capitol;
		private long population;
		private long grossDomesticProduct;
		private int happinessRank;
		
		//Constructor
		public Country(String name, String code, String capitol, long population,
			long grossDomesticProduct, int happinessRank)
		{
			this.name = name;
			this.code = code;
			this.capitol = capitol;
			this.population = population;
			this.grossDomesticProduct = grossDomesticProduct;
			this.happinessRank = happinessRank;
		}

		public String getName()
		{
			return this.name;
		}

		public String getCode()
		{
			return this.code;
		}

		public String getCapitol()
		{
			return this.capitol;
		}

		public long getPopulation()
		{
			return this.population;
		}

		public long getGDP()
		{
			return this.grossDomesticProduct;
		}

		public int getHappinessRank()
		{
			return this.happinessRank;
		}

		public void printCountry()
		{
			Console.WriteLine("%-33s %-10s %-20s %-15d %-16d %-10d %-10d\n", this.getName(), this.getCode(), this.getCapitol(),
					this.getPopulation(), this.getGDP(), this.getHappinessRank());
		}
	}
}

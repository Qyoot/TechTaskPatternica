using System.Collections.Generic;

namespace TechTaskPatternica
{
    
    public class Data
    {
        public int cdCount { get; set; }
        public decimal priceSum { get; set; }
        public int minYear { get; set; }
        public int maxYear { get; set; }
        public List<string> countries { get; set; }

        public Data(int cdCount, decimal priceSum, int minYear, int maxYear, List<string> countries)
        {
            this.cdCount = cdCount;
            this.priceSum = priceSum;
            this.minYear = minYear;
            this.maxYear = maxYear;
            this.countries = countries;
        }
    }
}

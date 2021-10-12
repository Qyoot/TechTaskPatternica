using System;
using System.Collections.Generic;
using System.Linq;

namespace TechTaskPatternica
{
    [Serializable]
   public class Analytics
    {
        private List<CATALOGCD> CDs;

        public Analytics(List<CATALOGCD> cDs)
        {
            CDs = cDs;
        }

        public Data GetData()
        {
            return new Data(CDs.Count, GetSum(), GetMinYear(), GetMaxYear(), GetCountries());
        }

        private decimal GetSum()
        {
            decimal result = 0;
            foreach (var item in CDs)
            {
                result += item.PRICE;
            }
            return result;
        }

        private List<string> GetCountries()
        {
            List<string> countries = new List<string>();
            foreach (var item in CDs)
            {
                countries.Add(item.COUNTRY);
            }
           countries =  countries.Distinct().ToList();
            return countries;
        }

        private int GetMinYear()
        {
            int min = 100000;
            foreach (var item in CDs)
            {
                if (min > item.YEAR)
                {
                    min = item.YEAR;
                }
            }
            return min;
        }

        private int GetMaxYear()
        {
            int max = 0;
            foreach (var item in CDs)
            {
                if (max < item.YEAR)
                {
                    max = item.YEAR;
                }
            }
            return max;
        }
    }
}

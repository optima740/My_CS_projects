using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            var birthData = new string[31];
            birthData[0] = "1";
            for (int i = 1; i < 31; i++)
            {
                birthData[i] = (i+1).ToString();
            }          
            var countEquals = new double[31];
            var index = 1;           
            for (int i = 1; i < 31; i++)
            {               
                var date = birthData[i];
                //if (i < 9) date = "0" + birthData[i];               
                foreach (var item in names)
                {
                    var tempDay = item.BirthDate.Day.ToString();
                    var tempName = item.Name;
                    if (tempName.Equals(name, StringComparison.OrdinalIgnoreCase) && tempDay.Equals(date, StringComparison.OrdinalIgnoreCase)) countEquals[index]++;
                }              
                index++;               
            }
            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name), 
                birthData, 
                countEquals);
        }
    }
}
using System;
namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            var birthData = new string[30];
            for (int i = 0; i < 30; i++) birthData[i] = (i + 2).ToString();
            var numderMonth = new string[12];
            for (int i = 0; i < 12; i++) numderMonth[i] = (i + 1).ToString();
            var countEquals = new double[30, 12];         
            foreach (var item in names)
            {
                var tempDay = (int)item.BirthDate.Day;
                var tempMonth = (int)item.BirthDate.Month;
                if (tempDay != 1) 
                    countEquals[tempDay - 2, tempMonth - 1]++;
            }           
            return new HeatmapData(
                "Пример карты интенсивностей",
                countEquals,
                birthData,
                numderMonth);
        }
    }
}
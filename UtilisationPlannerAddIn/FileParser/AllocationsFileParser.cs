using Csv;
using System;
using System.IO;
using UtilisationData;

namespace FileParser
{
    public class AllocationsFileParser
    {
        public static void ParseAllocationsFile(string allocationsFileName)
        {
            var csv = File.ReadAllText(allocationsFileName);

            string currentEmployee = "";
            foreach (var line in CsvReader.ReadFromText(csv))
            {
                var forecast = line["P3 Forecast"];
                var activityName = line["Resourced Activity: Activity Name"];
                var resourceName = line["Resource Name"];
                var accountName = line["Account: Account Name"];
                DateTime periodStartDate = new DateTime();
                DateTime.TryParse(line["Time Period: Start Date"], out periodStartDate);

                if (currentEmployee != resourceName)
                {
                    EmployeeUtilisation employeeUtilisation = new EmployeeUtilisation();
                }



            }
        }
    }
}

using Csv;
using System;
using System.IO;

namespace FileParser
{
    public class AllocationsFileParser
    {
        public static void ParseAllocationsFile(string allocationsFileName)
        {
            var csv = File.ReadAllText(allocationsFileName);
            foreach (var line in CsvReader.ReadFromText(csv))
            {
                // Header is handled, each line will contain the actual row data
                var firstCell = line[0];
                //var byName = line["Column name"];
            }
        }
    }
}

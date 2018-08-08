using FileParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing");
            Console.ReadKey();
            AllocationsFileParser.ParseAllocationsFile("C:\\Repos\\Utilisation_Planner\\Data\\report1532535058291.csv");
        }
    }
}
